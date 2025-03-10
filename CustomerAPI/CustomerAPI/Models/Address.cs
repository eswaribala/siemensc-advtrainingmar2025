namespace CustomerAPI.Models
{
    public class Address
    {
        public string DoorNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long Pincode { set; get; }
        public Customer Customer { get; set; }
    }
}
