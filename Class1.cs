
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_demo_2
{
    public class Class1
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"OrderId: {OrderId}, ProductName: {ProductName}, Quantity: {Quantity}, Price: {Price}";
        }

    }
}