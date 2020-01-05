using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("user_id")==null)
                ViewBag.Login= false;
            else
                ViewBag.Login= true;
            return View();
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("user_id")==null)
                return RedirectToAction("Index", "Home");
            ViewBag.Login = true;
            DashboardView dv = new DashboardView();
            dv.user = dbContext.Users.FirstOrDefault(u => u.UserID == HttpContext.Session.GetInt32("user_id"));
            List<Day> days = dbContext.Days.Where(d => d.WeekID == dv.user.ThisWeekID).ToList();
            Week week = dbContext.Weeks.Include(w => w.days).FirstOrDefault(w => w.WeekID == dv.user.NextWeekID);
            foreach (Day d in week.days)
            {
                days.Add(d);
            }
            dv.days = days.Where(d => d.date > DateTime.Now.AddDays(-1)).ToList();
            return View(dv); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
