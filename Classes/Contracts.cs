using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Supply_business.Entities;

namespace Supply_business.Classes
{
    public class Contracts
    {
        public List<Supplier> Suppliers { get; set; }
        
        public List<Good> Goods { get; set; }

        public Contracts()
        {
            Goods = new List<Good>();
            Suppliers = new List<Supplier>();
        }

        public Contracts(List<Supplier> supplier, List<Good> goods)
        {
            this.Suppliers = supplier;
            Goods = goods;
        }   
    }
}
