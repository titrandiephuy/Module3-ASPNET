using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace simple_login.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
                public IActionResult OnPost(string username, string password)
        {
            if (username == null || password == null)
            {
                return RedirectToPage("Index");
            }
            else if (username == "admin" && password == "123123")
            {
                Username = username;
                return RedirectToPage("Home", new { username = Username });
            }
            else
            {
                return RedirectToPage("Error");
            }
        }
        [BindProperty(Name = "Username", SupportsGet = true)] 
public string Username { get; set; }
    }
}
