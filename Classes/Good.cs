using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supply_business.Entities;
using System.ComponentModel;

namespace Supply_business.Classes
{
    [Serializable]
    public class Good
    {   static public int Id = 0;
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
            Id++;
            Name = name;
            Description = description;
            Price = price;
            Quantity = qunatity;
            GoodId = Id;
            supplier = _su;
        }

        public Good(DataRow row)
        {
            Id = Convert.ToInt32(row["Id"]);
            Name = row["Name"].ToString();
            Description = row["Description"].ToString();
            Price = Convert.ToDecimal(row["Price"]);
            Quantity = Convert.ToInt32(row["Quantity"]);
            supplier = new Supplier
            {
                SupplierName = (_SupplierName)Enum.Parse(typeof(_SupplierName), row["Supplier"].ToString()),
                DeliveryService = (_DeliveryService)Enum.Parse(typeof(_DeliveryService), row["Delivery"].ToString())
            };
        }

    }
}
