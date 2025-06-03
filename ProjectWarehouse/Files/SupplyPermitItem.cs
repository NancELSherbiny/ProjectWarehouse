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
       [Key] public int ID { get; set; } 
        [ForeignKey("SupplyPermit")]
        public int SPID { get; set; } 
        public virtual SupplyPermit SupplyPermit { get; set; } 
       [ForeignKey("item")] public int ItemID { get; set; } 
        public virtual Item Item { get; set; } 
        public int Quantity { get; set; } 
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; } 
       

    }
}
