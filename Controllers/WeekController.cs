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
    public class WeekController : Controller
    {
        private MyContext dbContext;

        public WeekController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("weeks")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            ViewBag.Login = true;
            WeekView week = new WeekView();
            week.user = dbContext.Users.FirstOrDefault(u => u.UserID == HttpContext.Session.GetInt32("user_id"));
            week.ThisWeek = dbContext.Weeks.Include(w => w.days).FirstOrDefault(w => w.WeekID == week.user.ThisWeekID);
            week.NextWeek = dbContext.Weeks.Include(w => w.days).FirstOrDefault(w => w.WeekID == week.user.NextWeekID);
            return View(week);
        }

        [HttpGet("day/{id}")]
        public IActionResult DayView(int id)
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            DayView dv = new DayView();
            dv.user = dbContext.Users.FirstOrDefault(u => u.UserID == HttpContext.Session.GetInt32("user_id"));
            Day day = dbContext.Days.Where(d => d.DayID == id).Include(d => d.breakfast).ThenInclude(b => b.recipe).Include(d => d.lunch).ThenInclude(l => l.recipe).Include(d => d.dinner).ThenInclude(d => d.recipe).FirstOrDefault();
            if ((day == null)||(day.UserID != dv.user.UserID))
            {
                return RedirectToAction("Index", "Home");
            }
            dv.day = day;
            dv.recipes = dbContext.Recipes.Where(r => r.CreatorID == dv.user.UserID).ToList();
            return View(dv);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
