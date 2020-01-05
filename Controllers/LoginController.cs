using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Project.Models;

namespace Project.Controllers
{
    public class LoginController : Controller
    {
        private MyContext dbContext;

        public LoginController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("register/login")]
        public IActionResult Index()
        {
            ViewBag.Login = false;
            return View();
        }
        
        [HttpPost("login")]
        public IActionResult Login(Login login)
        {
            Credentials credentials = login.OldUser;
            if (ModelState.IsValid)
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Email == credentials.Email);
                if (user == null)
                {
                    ModelState.AddModelError("OldUser.Email", "User not found");
                    return View("Index");
                }
                else
                {
                    var hasher = new PasswordHasher<Credentials>();
                    var result = hasher.VerifyHashedPassword(credentials, user.Password, credentials.Password);
                    if (result == 0)
                    {
                        ModelState.AddModelError("OldUser.Password", "Password is incorrect");
                        return View("Index");
                    }
                    User Current = dbContext.Users.FirstOrDefault(u => u.Email == credentials.Email);
                    HttpContext.Session.SetInt32("user_id", Current.UserID);
                    return RedirectToAction("Dashboard", "Home");
                }
            }
            else
            {
                ViewBag.Login = false;
                return View("Index");
            }
        }

        [HttpPost("register")]
        public IActionResult Register(Login login)
        {
            User user = login.NewUser;
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("NewUser.Email", "Email already in use");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();
                    User Current = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                    HttpContext.Session.SetInt32("user_id", Current.UserID);
                    SetupNewUser(Current);
                    return RedirectToAction("Dashboard", "Home");
                }
            }
            else
            {
                ViewBag.Login = false;
                return View("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult LogOut()
        {
            if (HttpContext.Session.GetInt32("user_id")==null)
                return RedirectToAction("Index", "Home");
            HttpContext.Session.Clear();
            ViewBag.Login = false;
            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void SetupNewUser(User user)
        {
            DateTime dt = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
            Week thisWeek = new Week();
            thisWeek.user = user;
            thisWeek.UserID = user.UserID;
            dbContext.Weeks.Add(thisWeek);
            dbContext.SaveChanges();
            Week tw = dbContext.Weeks.FirstOrDefault(w => w.UserID == user.UserID);
            Week nextWeek = new Week();
            nextWeek.user = user;
            nextWeek.UserID = user.UserID;
            dbContext.Weeks.Add(nextWeek);
            dbContext.SaveChanges();
            Week nw = dbContext.Weeks.LastOrDefault(w => w.UserID == user.UserID);
            for (int x = 0; x<14; x++)
            {
                Day day = new Day();
                day.date = dt.AddDays(x);
                day.user = user;
                day.UserID = user.UserID;
                if (x < 7)
                {
                    day.week = tw;
                    day.WeekID = tw.WeekID;
                    dbContext.Days.Add(day);
                    dbContext.SaveChanges();
                    day = dbContext.Days.LastOrDefault(d => d.WeekID == tw.WeekID);
                    tw.days.Add(day);
                    dbContext.Weeks.Update(tw);
                    dbContext.SaveChanges();
                }
                else
                {
                    day.week = nw;
                    day.WeekID = nw.WeekID;
                    dbContext.Days.Add(day);
                    dbContext.SaveChanges();
                    day = dbContext.Days.LastOrDefault(d => d.WeekID == nw.WeekID);
                    nw.days.Add(day);
                    dbContext.Weeks.Update(nw);
                    dbContext.SaveChanges();
                }
            }
            user.ThisWeekID = tw.WeekID;
            user.NextWeekID = nw.WeekID;
            dbContext.Users.Update(user);
            dbContext.SaveChanges();

        }
    }
    public static class DateTimeExtensions
        {
            public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
            {
                int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
                return dt.AddDays(-1 * diff).Date;
            }
        }
}