using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MediaBazaarWeb.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly INotyfService _notyf;

        public PrivacyModel(INotyfService notyf)
        {
            _notyf = notyf;
        }

        public void OnGet()
        {
            HttpContext.Session.SetString("user", "123");
            _notyf.Success("logged");
        }
    }
}
