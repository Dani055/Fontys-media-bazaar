using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using MBazaarClassLibrary.models;
using MBazaarClassLibrary.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWeb.Pages.Workdays
{
    public class ViewWorkweekModel : PageModel
    {
        private readonly INotyfService _notyf;
        public List<Workday> workweek = new List<Workday>();

        public void OnGet()
        {
            workweek = WorkdayService.GetOwnWorkweek(HttpContext.Session.GetLoggedEmp());
        }
    }
}
