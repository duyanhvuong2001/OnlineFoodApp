namespace OnlineFoodApp.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Currency { get; set; }
        public Shipping Shipping { get; set; }
    }
}
