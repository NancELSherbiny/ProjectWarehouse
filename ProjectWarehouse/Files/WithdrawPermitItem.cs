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
        [Key] public int ID { get; set; } 
        [ForeignKey("WithdrawPermit")]
        public int WPID { get; set; } 
        public virtual WithdrawPermit WithdrawPermit { get; set; } 
        [ForeignKey("Item")] public int ItemID { get; set; } 
        public virtual Item Item { get; set; } 
        public int Quantity { get; set; } 
    }
}
