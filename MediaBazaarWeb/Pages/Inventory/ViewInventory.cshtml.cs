using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using MBazaarClassLibrary.models;
using MBazaarClassLibrary.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWeb.Pages.Inventory
{
    public class ViewInventoryModel : PageModel
    {
        private readonly INotyfService _notyf;
        public List<Product> items = new List<Product>();

        [BindProperty(SupportsGet = true)]
        public string keyword { get; set; }

        public ViewInventoryModel(INotyfService notyf)
        {
            _notyf = notyf;
        }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetLoggedEmp() == null)
            {
                return RedirectToPage("/Index");
            }
            try
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    items = InventoryService.GetAllProducts();
                }
                else
                {
                    items = InventoryService.SearchProducts(keyword);
                }
                return Page();
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return Page();
            }
        }
    }
}
