using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Practice.Models
{
    internal class DishIngredient
    {
        public int Id { get; set; }
        public int DishId { get; set; }
        public int IngredientId { get; set; }
        public Dish Dish { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
