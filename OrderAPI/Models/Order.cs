namespace OrderAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderDescription { get; set; }
        public string OrderStatus { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }
        public string OrderAmount { get; set; }
    }
}
