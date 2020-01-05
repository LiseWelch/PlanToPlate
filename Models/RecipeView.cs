using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Project.Models
{
    public class RecipeView
    {
        public User user {get;set;}
        public Recipe recipe {get;set;}
        public Ingriedient NewIngriedient {get;set;}

        public string CreatedID {get;set;}

        public List<Ingriedient> items {get;set;} = new List<Ingriedient>();

        public string[] measurements = {"cup/cups","tsp/tsps","tbsp/tbsps","lb/lbs","oz/ozs", "item/items"};
    }
}