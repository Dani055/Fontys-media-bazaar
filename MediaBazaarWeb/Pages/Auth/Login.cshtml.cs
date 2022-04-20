using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using MBazaarClassLibrary.models;
using MBazaarClassLibrary.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWeb.Pages.Auth
{
    public class LoginModel : PageModel
    {
        private readonly INotyfService _notyf;

        [BindProperty]
        public Employee acc { get; set; }
        public LoginModel(INotyfService notyf)
        {
            _notyf = notyf;
        }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            try
            {
                Employee result = EmployeeService.Login(acc.Username, acc.Password);
                if (result != null)
                {
                    HttpContext.Session.SetObject("loggedEmp", result);
                    return RedirectToPage("/Index");
                }
                else
                {
                    return Page();
                }
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return Page();
            }
        }
    }
}
