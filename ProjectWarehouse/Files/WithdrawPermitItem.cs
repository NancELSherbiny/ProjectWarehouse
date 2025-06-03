using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class WithdrawPermitItem
    {
        [Key] public int ID { get; set; } // Unique identifier for the withdraw permit item
        [ForeignKey("WithdrawPermit")]
        public int WPID { get; set; } // Withdraw Permit ID
        public virtual WithdrawPermit WithdrawPermit { get; set; } // Navigation property to WithdrawPermit
        [ForeignKey("Item")] public int ItemID { get; set; } // Item ID
        public virtual Item Item { get; set; } // Navigation property to Item
        public int Quantity { get; set; } // Quantity of the item in the withdraw permit
    }
}
