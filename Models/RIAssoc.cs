using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models 
{
    public class RIAssoc {
        
        [Key]
        public int RIAssocID { get; set; }

        public int IngriedientID { get; set; }
        public Ingriedient ingriedient { get; set; }

        public int RecipeID { get; set; }
        public Recipe recipe { get; set; }
    }
}