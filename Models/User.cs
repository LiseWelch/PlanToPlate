using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Project.Models
{
    public class User 
    {
        [Key]
        public int UserID {get; set;}

        [Required(ErrorMessage="First name is required")]
        [MinLength(2, ErrorMessage="First name must be at least 2 characters long")]
        [Display(Name="First Name: ")]
        public string FirstName {get;set;}

        [Required(ErrorMessage="Last name is required")]
        [MinLength(2, ErrorMessage="Last name must be at least 2 characters long")]
        [Display(Name="Last Name: ")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Username is required")]
        [MinLength(4, ErrorMessage="Username must be at least 4 characters long")]
        [MaxLength(20, ErrorMessage="Username cannot be longer then 20 characters")]
        [Display(Name="Username: ")]
        public string Username {get;set;}

        [Required(ErrorMessage="First name is required")]
        [EmailAddress]
        [Display(Name="Email: ")]
        public string Email {get;set;}

        [Required(ErrorMessage="Password is required")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[!@#$%^&*(),.?:""{}|<>_-]).{8,}$", ErrorMessage="Password must contain at least 1 number, 1 letter, and 1 special character.")]
        [DataType(DataType.Password)]
        [Display(Name="Password: ")]
        public string Password {get;set;}

        [NotMapped]
        [Required(ErrorMessage="Must confirm password")]
        [Compare("Password", ErrorMessage="Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password: ")]
        public string Confirm {get;set;}
        
        public List<GroceryList> CreatedLists {get;set;} = new List<GroceryList>();
        public List<GUAssoc> InvitedLists {get;set;} = new List<GUAssoc>();

        public List<Recipe> CreatedRecipes {get;set;} = new List<Recipe>();
        public List<RUAssoc> LikedResipes {get;set;} = new List<RUAssoc>();

        public int ThisWeekID {get;set;}
        public int NextWeekID{get;set;}


    }

}