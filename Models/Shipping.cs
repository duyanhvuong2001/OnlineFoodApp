namespace OnlineFoodApp.Models
{
    public class Shipping
    {
        public Guid Id { get; set; }
        public int PhoneNumber { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
        public string Line1 { get; set; }
        public string Suburb { get; set; }
        public Customer Customer { get; set; }
    }
}
