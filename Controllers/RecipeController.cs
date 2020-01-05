using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Project.Models;
using Microsoft.EntityFrameworkCore;
using Project.Hubs;

namespace Project.Controllers
{
    public class RecipeController : Controller
    {
        private MyContext dbContext;
 
        public List<Ingriedient> CurItems {get;set;} = new List<Ingriedient>();

        public RecipeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("recipes")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            ViewBag.Login = true;
            RecipeView rv = new RecipeView();
            rv.user = dbContext.Users.Include(u => u.CreatedRecipes).FirstOrDefault();
            rv.user.CreatedRecipes = rv.user.CreatedRecipes.OrderBy(r => r.Name).ToList();
            int count = rv.user.CreatedRecipes.Count;
            if (count != 0)
            {
                Random rand = new Random();
                Recipe recipe = rv.user.CreatedRecipes[rand.Next(count)];
                rv.recipe = dbContext.Recipes.Where(r => r.RecipeID == recipe.RecipeID).Include(r => r.ingriedients).ThenInclude(assoc => assoc.ingriedient).FirstOrDefault();
            }
            return View(rv);
        }

        [HttpGet("recipes/{id}")]
        public IActionResult ViewRecipe(int id)
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            ViewBag.Login = true;
            RecipeView rv = new RecipeView();
            rv.user = dbContext.Users.Include(u => u.CreatedRecipes).FirstOrDefault();
            Recipe recipe = dbContext.Recipes.Where(r => r.RecipeID == id).Include(r => r.Creator).Include(r => r.ingriedients).ThenInclude(assoc => assoc.ingriedient).FirstOrDefault();
            if ((recipe == null)||(recipe.Creator.UserID != rv.user.UserID))
            {
                return RedirectToAction("Index");
            }
            else
            {
                rv.user.CreatedRecipes = rv.user.CreatedRecipes.OrderBy(r => r.Name).ToList();
                rv.recipe = recipe;
                return View("Index",rv);
            }
        }

        [HttpGet("recipes/delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            RecipeView rv = new RecipeView();
            rv.user = dbContext.Users.Include(u => u.CreatedRecipes).FirstOrDefault();
            Recipe recipe = dbContext.Recipes.Where(r => r.RecipeID == id).Include(r => r.Creator).Include(r => r.ingriedients).ThenInclude(assoc => assoc.ingriedient).FirstOrDefault();
            if ((recipe == null)||(recipe.Creator.UserID != rv.user.UserID))
            {
                return RedirectToAction("Index");
            }
            else
            {
                int count = recipe.ingriedients.Count;
                for (int x = 0; x < count; x++)
                {
                    dbContext.Ingriedients.Remove(recipe.ingriedients[0].ingriedient);
                    dbContext.SaveChanges();
                }
                dbContext.Recipes.Remove(recipe);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        
        [HttpGet("recipes/edit/{id}")]
        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            RecipeView rv = new RecipeView();
            rv.user = dbContext.Users.Include(u => u.CreatedRecipes).FirstOrDefault();
            Recipe recipe = dbContext.Recipes.Where(r => r.RecipeID == id).Include(r => r.Creator).Include(r => r.ingriedients).ThenInclude(assoc => assoc.ingriedient).FirstOrDefault();
            if ((recipe == null)||(recipe.Creator.UserID != rv.user.UserID))
            {
                return RedirectToAction("Index");
            }
            else
            {
                rv.recipe = recipe;
                rv.CreatedID = recipe.CreatedID;
                return View(rv);
            }
        }
        
        [HttpGet("recipes/add")]
        public IActionResult Add()
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            ViewBag.Login = true;
            RecipeView rv = new RecipeView();
            rv.user = dbContext.Users.Include(u => u.CreatedRecipes).FirstOrDefault();
            rv.user.CreatedRecipes = rv.user.CreatedRecipes.OrderBy(r => r.Name).ToList();
            rv.CreatedID = $"{DateTime.Now.ToString()} {rv.user.UserID}";
            return View(rv);
        }

        [HttpPost("recipes/add")]
        public IActionResult Create(RecipeView rv)
        {
            if (HttpContext.Session.GetInt32("user_id") == null)
                    return RedirectToAction("Index", "Home");
            ViewBag.Login = true;
            string search = rv.recipe.CreatedID;
            List<Ingriedient> items = dbContext.Ingriedients.Where(i => i.CreatedId == search).ToList();
            if (ModelState.IsValid)
            {
                Recipe recipe = rv.recipe;
                recipe.Creator = dbContext.Users.FirstOrDefault(u => u.UserID == HttpContext.Session.GetInt32("user_id"));
                recipe.CreatorID = recipe.Creator.UserID;
                dbContext.Recipes.Add(recipe);
                dbContext.SaveChanges();
                recipe = dbContext.Recipes.FirstOrDefault(r => r.CreatedID == search);
                foreach (Ingriedient i in items)
                {
                    RIAssoc assoc = new RIAssoc();
                    assoc.IngriedientID = i.IngriedientID;
                    assoc.ingriedient = i;
                    assoc.recipe = recipe;
                    assoc.RecipeID = recipe.RecipeID;
                    dbContext.RIAssocs.Add(assoc);
                    dbContext.SaveChanges();
                }
                return Redirect(($"/recipes/{recipe.RecipeID}"));
            }
            RecipeView newRV = new RecipeView();
            newRV.user = dbContext.Users.FirstOrDefault(u => u.UserID == HttpContext.Session.GetInt32("user_id"));
            newRV.items = items;
            newRV.CreatedID = search;
            return View("Add", newRV);
        }
      
        [HttpPost("recipes/save/{id}")]
        public IActionResult Save(RecipeView rv, int id)
        {
           if (HttpContext.Session.GetInt32("user_id") == null)
                return RedirectToAction("Index", "Home");
            string search = rv.recipe.CreatedID;
            List<Ingriedient> items = dbContext.Ingriedients.Where(i => i.CreatedId == search).ToList();
            List<RIAssoc> items2 = dbContext.RIAssocs.Where(r => r.RecipeID == id).ToList();
            rv.user = dbContext.Users.Include(u => u.CreatedRecipes).FirstOrDefault();
            Recipe recipe = dbContext.Recipes.Where(r => r.RecipeID == id).Include(r => r.Creator).Include(r => r.ingriedients).ThenInclude(assoc => assoc.ingriedient).FirstOrDefault();
            if ((recipe == null)||(recipe.Creator.UserID != rv.user.UserID))
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Recipe update = rv.recipe;
                    recipe.Name = update.Name;
                    recipe.PrepTimeInt = update.PrepTimeInt;
                    recipe.PrepTimeString = update.PrepTimeString;
                    recipe.Instructions = update.Instructions;
                    dbContext.Recipes.Update(recipe);
                    dbContext.SaveChanges();
                    foreach (RIAssoc i in items2)
                    {
                        items.Remove(i.ingriedient);
                    }
                    foreach (Ingriedient i in items)
                    {
                        RIAssoc assoc = new RIAssoc();
                        assoc.IngriedientID = i.IngriedientID;
                        assoc.ingriedient = i;
                        assoc.recipe = recipe;
                        assoc.RecipeID = recipe.RecipeID;
                        dbContext.RIAssocs.Add(assoc);
                        dbContext.SaveChanges();
                    }
                    return Redirect($"/recipes/{recipe.RecipeID}");
                }
                RecipeView NEWrv = new RecipeView();
                NEWrv.user = dbContext.Users.Include(u => u.CreatedRecipes).FirstOrDefault();
                NEWrv.recipe = recipe;
                NEWrv.CreatedID = recipe.CreatedID;
                return View("Edit", NEWrv);    
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
