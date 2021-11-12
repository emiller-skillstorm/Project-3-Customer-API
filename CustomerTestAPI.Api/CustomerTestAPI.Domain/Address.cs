using System;
namespace CustomerTestAPI.Domain
{
    public class Address
    {
        public string Street_1 { get; set; }
        public string Street_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string DeliveryInstructions { get; set; }
    }
}
