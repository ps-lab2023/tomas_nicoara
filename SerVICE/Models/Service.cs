namespace SerVICE.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Price { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = new User();
        public virtual Category Category { get; set; } = new Category();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
