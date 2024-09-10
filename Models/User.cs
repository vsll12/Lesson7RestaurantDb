﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practice.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public int MediaUserId { get; set; }
        public MediaUser MediaUser { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}
