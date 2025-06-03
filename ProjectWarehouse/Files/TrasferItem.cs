using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class TransferItem
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Transfer")]
        public int TransferID { get; set; }
        public virtual Transfer Transfer { get; set; }

        [ForeignKey("Item")]
        public int IID { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; } 
        public DateTime ProductionDate { get; set; } 
        public DateTime ExpiryDate { get; set; } 

    }
}
