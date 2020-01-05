using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Project.Models
{
    public class GUAssoc
    {
        [Key]
        public int GUAssocID {get;set;}

        public int UserID {get;set;}
        public User user {get;set;}

        public int ListID {get;set;}
        public GroceryList gList {get;set;}
    }
}