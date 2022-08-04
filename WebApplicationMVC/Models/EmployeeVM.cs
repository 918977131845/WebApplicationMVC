using System;

namespace WebApplicationMVC.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int FisrstName { get; set; }
        public int LastName { get; set; }
        public string TaxID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
