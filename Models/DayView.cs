using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Project.Models
{
    public class DayView
    {
        public User user {get;set;}
        public Ingriedient NewIngriedient {get;set;}

        public string CreatedID {get;set;}

        public Day day {get;set;}

        public List<Breakfast> breakfasts {get;set;} = new List<Breakfast>();
        public List<Lunch> lunches {get;set;} = new List<Lunch>();
        public List<Dinner> dinners {get;set;} = new List<Dinner>();
        public List<Recipe> recipes {get;set;} = new List<Recipe>();

        public string[] measurements = {"cup/cups","tsp/tsps","tbsp/tbsps","lb/lbs","oz/ozs", "item/items"};
    }
}