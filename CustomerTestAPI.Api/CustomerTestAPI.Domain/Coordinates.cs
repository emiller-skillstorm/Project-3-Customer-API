using System;
using System.ComponentModel.DataAnnotations;

namespace CustomerTestAPI.Domain
{
    public class Coordinates
    {
        [Key]
        public int Coordinate_ID { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
