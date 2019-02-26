using BlogPostCMS.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPostCMS.Models.Components
{
   
    public class TopArticles : ViewComponent
    {
        private BlogDbContext _context;

        public TopArticles(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var posts = _context.Posts.OrderByDescending(a => a.ID)
                .Take(number).ToList();
            return View(posts);
        }
    }
}
