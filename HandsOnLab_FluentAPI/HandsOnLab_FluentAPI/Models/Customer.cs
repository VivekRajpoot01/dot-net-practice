using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnLab_FluentAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsPremium { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
