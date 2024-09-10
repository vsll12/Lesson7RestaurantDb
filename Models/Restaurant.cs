
namespace Lesson7Practice.Models
{
    internal class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int MediaRestaurantId { get; set; }
        public int CategoryId { get; set; }
        public MediaRestaurant mediaRestaurant { get; set; }
        public Category category { get; set; }
        public List<User> Users { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
