using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_HW6.Models
{
    public class Bill
    {
        public List<Product> Products { get; set; }

        public Guid Id => Guid.NewGuid();

        public decimal Amount => Products.Sum(x => x.Price);

        public DateTime OrderTime { get; set; }
    }
}
