using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace OrderStores.Domain.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDetails { get; set; }
        public bool IsActive { get; set; }
        public DateTime OrderedDate { get; set; }
    }
}