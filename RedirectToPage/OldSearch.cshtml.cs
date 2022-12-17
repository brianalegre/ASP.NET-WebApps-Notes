using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zoogle.Pages
{
  public class OldSearchModel : PageModel
  {
    public IActionResult OnGet()
    {
      return RedirectToPage("/Search");
    }
  }
}
