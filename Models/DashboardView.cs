using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Project.Models
{
    public class DashboardView
    {
        public User user {get;set;}

        public string[] values = {"One", "Two","Three", "Four", "Five", "Six", "Seven"};

        public List<Day> days {get;set;} = new List<Day>();
    }
}