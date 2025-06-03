using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class SupplyPermitItem
    {
       [Key] public int ID { get; set; } // Unique identifier for the supply permit item
        [ForeignKey("SupplyPermit")]
        public int SPID { get; set; } // Supply Permit ID
        public virtual SupplyPermit SupplyPermit { get; set; } // Navigation property to SupplyPermit
       [ForeignKey("item")] public int ItemID { get; set; } // Item ID
        public virtual Item Item { get; set; } // Navigation property to Item
        public int Quantity { get; set; } // Quantity of the item in the supply permit
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; } // Expiry date of the item in the supply permit
       

    }
}
