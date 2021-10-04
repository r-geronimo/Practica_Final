using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Practica_Final.Pages.Dashboard
{
    [Authorize(AuthenticationSchemes = "Cookies")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

            string idUsuario = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
