namespace CustomerManager.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public int CustomerTypeId { get; set; } 
        public CustomerType? CustomerType { get; set; }
        public string? Sex { get; set; }
        public int CustomerStateId { get; set; }
        public CustomerState? CustomerState { get; set; }
    }
}
