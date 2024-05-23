using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Supply_business.Entities
{
    [Serializable]
    public enum _SupplierName
    {
        Amazon,
        eBay,
        Shein
    }

    [Serializable]
    public enum _DeliveryService
    {
        DHL,
        FedEx,
        UPS
    }

    [Serializable]
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
