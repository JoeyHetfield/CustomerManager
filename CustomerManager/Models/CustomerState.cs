namespace CustomerManager.Models
{
    public class CustomerState
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Customer>? Customers { get; set; } 
    }
}
