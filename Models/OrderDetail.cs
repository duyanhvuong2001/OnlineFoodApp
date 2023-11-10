namespace OnlineFoodApp.Models
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Item Item { get; set; }
        public Order Order { get; set; }
    }
}
