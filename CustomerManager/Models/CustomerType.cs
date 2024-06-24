namespace CustomerManager.Models
{
    public class CustomerType
    {
        public int Id { get; set; }
        public string? CustomerDescription { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
