﻿using System.Collections.Generic;

namespace DotnetConfDemo.Models
{


    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        //This is called a navigation property
        public ICollection<Order> Orders { get; set; }
    }   
}