using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_business.Classes
{

    public class Good
    {   static public int id = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Good()
        { 
        }
        public Good( string name, string description, decimal price, int qunatity)
        {
            id++;
            Name = name;
            Description = description;
            Price = price;
            Quantity = qunatity;
        }
    }
}
