using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Project.Models
{
    public class RUAssoc
    {
        [Key]
        public int RUAssocID {get;set;}

        public int UserID {get;set;}
        public User user {get;set;}

        public int RecipeID {get;set;}
        public Recipe recipe {get;set;}
    }
}