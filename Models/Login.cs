using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Project.Models
{
    public class Login
    {
        public User NewUser {get;set;}
        public Credentials OldUser {get;set;}
    }
}