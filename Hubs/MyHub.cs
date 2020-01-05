using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Project.Models;
using Microsoft.AspNetCore.SignalR;
using System.Web;

namespace Project.Hubs
{

    public class MyHub : Hub
    {
        private MyContext dbContext;

        public MyHub(MyContext context)
        {
            dbContext = context;
        }

        public async Task AddItem(string name, double amount, string amountType, string user, string createdAt)
        {
            Ingriedient newI = new Ingriedient();
            newI.Name = name;
            newI.AmountNum = amount;
            newI.AmountString = amountType;
            newI.CreatedId = createdAt;
            string item = $"{amount} {amountType} {name}";
            dbContext.Ingriedients.Add(newI);
            dbContext.SaveChanges();
            Ingriedient cur = dbContext.Ingriedients.FirstOrDefault(i => (i.CreatedId == createdAt)||(i.Name==name));
            await Clients.Client(user).SendAsync("PrintItem", item, cur.IngriedientID);
        }
        
        public async Task AddRecipe(string rID, string user, string day)
        {
            Breakfast b = new Breakfast();
            b.DayID = (int)System.Convert.ToUInt32(day);
            b.day = dbContext.Days.FirstOrDefault(d => d.DayID == b.DayID);
            b.RecipeID = (int)System.Convert.ToUInt32(rID);
            b.recipe = dbContext.Recipes.FirstOrDefault(r => r.RecipeID == b.RecipeID);
            dbContext.Breakfasts.Add(b);
            dbContext.SaveChanges();
            await Clients.Client(user).SendAsync("PrintRecipe", b.recipe.Name, b.RecipeID);
        }

        public async Task HubDeleteItem(string itemID, string user)
        {
            Ingriedient del = dbContext.Ingriedients.FirstOrDefault(i => i.IngriedientID == System.Convert.ToUInt32(itemID));
            dbContext.Ingriedients.Remove(del);
            dbContext.SaveChanges();
            await Clients.Client(user).SendAsync("DeleteItem", itemID);
        }

        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }


    }
}