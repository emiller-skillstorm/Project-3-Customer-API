using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTestAPI.Domain
{
    public class Coordinates
    {
        [Key]
        public int Id { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
