using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ExplorellaModel : PageModel
    {
        public string Country { get; set; }
        public void OnGet()
        {
            // Assign Properties
            Countries = new List<SelectListItem>
        {
          new SelectListItem {Value = "AR", Text = "Argentina"},
          new SelectListItem {Value = "FR", Text = "France"},
          new SelectListItem {Value = "BR", Text = "Brazil"},
          new SelectListItem {Value = "GER", Text = "Germany"},
          new SelectListItem {Value = "CHI", Text = "China"},
        };
        }

        // Create a List 
        // Add Getter and Setter
        public List<SelectListItem> Countries
        { get; set; }

    }
}
