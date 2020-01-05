using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Lunch
    {
        [Key]
        public int LunchID { get; set; }

        public int DayID { get; set; }
        public Day day { get; set; }

        public int RecipeID { get; set; }
        public Recipe recipe { get; set; }
    }
}