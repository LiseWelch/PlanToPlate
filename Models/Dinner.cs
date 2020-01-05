using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Dinner
    {
        [Key]
        public int DinnerID { get; set; }

        public int DayID { get; set; }
        public Day day { get; set; }

        public int RecipeID { get; set; }
        public Recipe recipe { get; set; }
    }
}