namespace OnlineFoodApp.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string GTIN { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string SKU { get; set; }
        public string Brand { get; set; }
        public Price Price { get; set; }
    }
}
