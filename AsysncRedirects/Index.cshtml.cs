using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Zoogle.Models;

namespace Zoogle.Pages
{
    public class IndexModel : PageModel
    {
        public List<Animal> Animals { get; set; }

        public IActionResult OnGet()
        {
            Animals = Zoo.Animals;

            // Asynchronous code
            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
                await writer.WriteLineAsync($"Zoogle visit recorded at {DateTime.Now}.");
            }

            return Page();
        }
    }
}