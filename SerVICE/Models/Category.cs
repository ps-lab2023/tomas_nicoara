namespace SerVICE.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Service>? Services { get; set; } = new List<Service>();
    }
}
