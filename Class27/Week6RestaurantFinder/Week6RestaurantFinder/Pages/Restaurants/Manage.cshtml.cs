using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Week6RestaurantFinder.Models;
using Week6RestaurantFinder.Models.Interfaces;

namespace Week6RestaurantFinder.Pages.Restaurants
{
    public class ManageModel : PageModel
    {
        private readonly IRestaurant _restaurant;

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public ManageModel(IRestaurant restaurant)
        {
            _restaurant = restaurant;
        }

        public async Task OnGet()
        {
            Restaurant = await _restaurant.FindRestaurant(ID.GetValueOrDefault()) ?? new Restaurant();
        }

        public async Task<IActionResult> OnPost()
        {
            // Make the call to our DB with our ID.
            var rest = await _restaurant.FindRestaurant(ID.GetValueOrDefault()) ?? new Restaurant();

            // set the data from the database to the new data from Restaurant/user input
            rest.Name = Restaurant.Name;
            rest.Description = Restaurant.Description;
            rest.StarRating = Restaurant.StarRating;

            // Save the restaurant in the database
            await _restaurant.SaveAsync(rest);

            return RedirectToPage("/Restaurants/Index", new { id = rest.ID });
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await _restaurant.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");
        }
    }
}