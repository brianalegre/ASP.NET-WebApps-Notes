using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zoogle.Models;

namespace Zoogle.Pages
{
  public class SearchModel : PageModel
  {
    public List<Animal> Animals { get; set; }
    public Animal FoundAnimal { get; set; }
    public string SearchString { get; set; }

#nullable enable
    public IActionResult OnGet(string? searchString)
    {
      Animals = Zoo.Animals;

      if (!string.IsNullOrEmpty(searchString))
      {
        // Check if searchString is "all" here
        if (searchString.ToLower() == "all")
        {
          return RedirectToPage("/Index");
        }
        
        FoundAnimal = Animals
          .Where(a => a.CommonName == searchString)
          .FirstOrDefault();
      }

      // Call Page() here
      return Page();
    }
#nullable disable
  }
}