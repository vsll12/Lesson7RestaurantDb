﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practice.Models
{
    internal class Review
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public User User { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
