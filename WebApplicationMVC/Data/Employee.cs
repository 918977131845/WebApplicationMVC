using Microsoft.AspNetCore.Identity;
using System;

namespace WebApplicationMVC.Data
{
    public class Employee : IdentityUser
    {
        public int FisrstName { get; set; } 
        public int LastName { get; set; }
        public string TaxID { get; set; }
        public DateTime  DateOfBirth { get; set; }  
        public DateTime DateJoined { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
