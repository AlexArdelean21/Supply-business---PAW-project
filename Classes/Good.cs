using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supply_business.Entities;

namespace Supply_business.Classes
{

    public class Good
    {   static public int id = 0;
        public int GoodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Supplier supplier { get; set; }

        public Good()
        {
            supplier = new Supplier();
        }
        public Good(string name, string description, decimal price, int qunatity, Supplier _su)
        {
            id++;
            Name = name;
            Description = description;
            Price = price;
            Quantity = qunatity;
            GoodId = id;
            supplier = _su;
        }
    }
}
