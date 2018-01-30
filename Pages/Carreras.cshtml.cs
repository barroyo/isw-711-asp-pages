using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class CarrerasModel : PageModel
    {
        public string[] Carreras { get; set; }

        public void OnGet()
        {
          Carreras = new string[]{ "ISW", "COFI", "ASM", "OTRA" };
        }
    }
}
