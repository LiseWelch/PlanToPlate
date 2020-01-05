using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Project.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeID {get;set;}

        [Required]
        public string Name {get;set;} = "";

        [Required]
        public int PrepTimeInt {get;set;}

        [Required]
        public string PrepTimeString {get;set;}

        public string Instructions {get;set;}

        public string CreatedID {get;set;}

        public int CreatorID {get;set;}
        public User Creator {get;set;}

        public List<RUAssoc> LikedBy {get;set;} = new List<RUAssoc>();
        public List<RIAssoc> ingriedients {get;set;} = new List<RIAssoc>();

    }
}