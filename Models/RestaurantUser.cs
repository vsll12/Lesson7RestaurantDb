using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practice.Models
{
    internal class RestaurantUser
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int UserId { get; set; }
        public Restaurant Restaurant { get; set; }
        public User User { get; set; }
    }
}
