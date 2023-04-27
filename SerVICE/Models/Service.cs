using System.Text.Json.Serialization;

namespace SerVICE.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Price { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<Category>? Category { get; set; }
        [JsonIgnore]    
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
