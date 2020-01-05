using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Project.Models
{
    public class GroceryList
    {
        [Key]
        public int ListID {get;set;}

        [Required]
        public string ListName {get;set;}

        public List<Ingriedient> Items {get;set;} = new List<Ingriedient>();

        public int CreatorID {get;set;}
        public User Creator {get;set;}

        public List<GUAssoc> users {get;set;} = new List<GUAssoc>();

        public List<GIAssoc> ingriedients {get;set;} = new List<GIAssoc>();
    }
}