using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTestAPI.Domain
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Phone { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public virtual Address Address { get; set; }
        public string Notes { get; set; }
    }
}
