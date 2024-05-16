using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_business.Entities
{
    public class Supplier
    {
        static public int Id = 0;
        public string Name { get; set; }
        public string Email { get; set; }

        public Supplier()
        {
        }

        public Supplier(string name, string email)
        {
            Id++;
            Name = name;
            Email = email;
        }
    }
}
