using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class AboutModel : PageModel
    {
        // public string Message { get; set; }

        // public string Phone { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "About Us Page";
            ViewData["Message"] = "Your application description page.";
            ViewData["Phone"] = "88771677";

        }
    }
}
