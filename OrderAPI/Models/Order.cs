namespace OrderAPI.Models
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Completed,
        Cancelled
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderDescription { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string OrderDate { get; set; }        
        public string OrderAmount { get; set; }
    }
}
