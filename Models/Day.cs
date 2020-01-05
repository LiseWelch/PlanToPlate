using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Project.Models
{
    public class Day
    {
        [Key]
        public int DayID {get;set;}

        public DateTime date {get;set;}

        public List<Breakfast> breakfast {get;set;} = new List<Breakfast>();
        public List<Lunch> lunch {get;set;} = new List<Lunch>();
        public List<Dinner> dinner {get;set;} = new List<Dinner>();

        public int WeekID {get;set;}
        public Week week {get;set;}

        public int UserID {get;set;}
        public User user {get;set;}

    }
}