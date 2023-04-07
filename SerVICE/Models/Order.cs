namespace SerVICE.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; } = new Service();
        public int BuyerId { get; set; }
        public virtual User Buyer { get; set; } = new User();
    }
}
