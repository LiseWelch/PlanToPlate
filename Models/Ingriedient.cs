using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Project.Models
{
    public class Ingriedient
    {
        [Key]
        public int IngriedientID {get;set;}

        [Required]
        public string Name {get;set;}

        [Required]
        public double AmountNum {get;set;}

        [Required]
        public string AmountString {get;set;}

        public string CreatedId {get;set;} = "";

        public List<RIAssoc> recipes {get;set;} = new List<RIAssoc>();

        public List<GIAssoc> gList {get;set;} = new List<GIAssoc>();
    }
}