using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ProfileModel : PageModel
    {
        public void OnGet()
        {
            // Add ViewData with key value pairs
            ViewData["myName"] = "Brian";
            ViewData["username"] = "Frantik";
            ViewData["myOccupation"] = "Software Engineer";
            ViewData["myAge"] = 35;
            ViewData["currentDate"] = "11/23/22";



        }
    }
}
