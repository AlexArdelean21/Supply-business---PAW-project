using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_business.Entities
{
    public enum _SupplierName
    {
        Amazon,
        eBay,
        Shein
    }
    public enum _DeliveryService
    {
        DHL,
        FedEx,
        UPS
    }
    public class Supplier
    {
        public _SupplierName SupplierName { get; set; }
        public _DeliveryService DeliveryService { get; set; }
        public Supplier()
        {
        }
        public Supplier(_SupplierName supplierName, _DeliveryService deliveryService)
        {
            SupplierName = supplierName;
            DeliveryService = deliveryService;
        }
    }
}
