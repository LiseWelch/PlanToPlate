using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Project.Models
{
    public class WeekView
    {
        public User user { get; set; }

        public Week ThisWeek {get;set;}

        public Week NextWeek {get;set;}
    }
}