using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models 
{
    public class GIAssoc {
        [Key]
        public int GIAssocID { get; set; }

        public int IngriedientID { get; set; }
        public Ingriedient ingriedient { get; set; }

        [Required]
        public int AmountInt { get; set; }

        [Required]
        public string AmountString { get; set; }

        public int ListID { get; set; }
        public GroceryList gList { get; set; }
    }
}