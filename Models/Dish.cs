using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practice.Models
{
    internal class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int MediaMenuId { get; set; }
        public int RestaurantId { get; set; }
        public MediaMenu MediaMenu { get; set; }
        public Restaurant Restaurant { get; set; }
        public int DishCategoryId { get; set; }
        public DishCategory DishCategory { get; set; }
    }
}
