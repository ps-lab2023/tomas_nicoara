namespace SerVICE.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public virtual ICollection<Service> Services { get; set; } = new List<Service>();
    }
}
