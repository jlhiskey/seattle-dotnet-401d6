using BlogPostCMS.Models;
using BlogPostCMS.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlogPostCMS.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        /// <summary>
        /// Default Register Page
        /// </summary>
        /// <returns>Return the View of the Register page</returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                // Create a new Application User
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    Birthday = rvm.Birthday
                };

                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    Claim fullNameClaim = new Claim("FullName", $"{user.FirstName} {user.LastName}");

                    Claim birthdayClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthday.Year, user.Birthday.Month, user.Birthday.Day).ToString("u"),
                        ClaimValueTypes.DateTime);

                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    List<Claim> claims = new List<Claim> { fullNameClaim, birthdayClaim, emailClaim };

                    await _userManager.AddClaimsAsync(user, claims);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");

                }

            }

            return View(rvm);

        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            return View(lvm);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult ExternalLogin(string provider)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account");
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            return Challenge(properties, provider);
        }

        [HttpGet]

        public async Task<IActionResult> ExternalLoginCallback(string error = null)
        {
            // If there is an error message, send them away
            if (error != null)
            {
                // logging of the error coming in
                TempData["Error"] = "Error with Provider";
                return RedirectToAction("Login");
            }

            // see if our web app supports the login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();

            // If the web app does not support the provider, make them login with a different technique.
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            // login with the external provider given the info from our sign in manager
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            // redirect them home if the login was a success
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            //get the email if this is the first time
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);

            //redirect to the external login page for the user to 
            return View("ExternalLogin", new ExternalLoginViewModel { Email = email });

        }


        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginViewModel elvm)
        {
            if (ModelState.IsValid)
            {
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    TempData["Error"] = "Error loading information";
                }

                //Create the user.
                //TODO: Could potentially force the user to add a password here....
                //
                var user = new ApplicationUser { UserName = elvm.Email, Email = elvm.Email };

                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    //TODO: Potentially add Claims here.....

                    result = await _userManager.AddLoginAsync(user, info);

                    if (result.Succeeded)
                    {
                        // sign the user in with the information they gave us
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("Index", "Home");

                    }
                }


            }
            return View(elvm);
        }
    }
}
