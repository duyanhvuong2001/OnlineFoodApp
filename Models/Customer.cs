namespace OnlineFoodApp.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public int PhoneNumber { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
