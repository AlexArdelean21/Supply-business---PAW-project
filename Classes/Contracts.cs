using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Supply_business.Entities;
using System.ComponentModel;

namespace Supply_business.Classes
{
    public class Contracts
    {        
        public List<Good> Goods { get; set; }
        public Contracts()
        {
           Goods = new List<Good>();
        }

        public Contracts(List<Good> _goods)
        {
            List < Good > Goods = _goods;
        }
    }
}
