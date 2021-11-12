using System;
namespace CustomerTestAPI.Domain
{
    public class Customer
    {
        public int Customer_ID { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Coordinates Coord { get; set; }
    }
}
