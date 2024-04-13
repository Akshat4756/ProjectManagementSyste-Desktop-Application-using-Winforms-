﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }   
        public string Gender { get; set; }
        public byte[] Image { get; set; }
        public string Role { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
