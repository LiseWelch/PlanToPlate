using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Project.Models
{
    public class Week
    {
        [Key]
        public int WeekID { get; set; }

        public List<Day> days {get;set;} = new List<Day>();

        public int UserID {get;set;}
        public User user {get;set;}
    }
}