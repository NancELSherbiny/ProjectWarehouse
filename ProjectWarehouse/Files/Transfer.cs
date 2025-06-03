using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class Transfer
    {
        public Transfer()
        {
            TransferItems = new HashSet<TransferItem>();
        }
        [Key]
        public int ID { get; set; }

        [ForeignKey("FromWarehouse")]
        public int FromW { get; set; }
        public virtual Warehouse FromWarehouse { get; set; }

        [ForeignKey("ToWarehouse")]
        public int ToW { get; set; }
        public virtual Warehouse ToWarehouse { get; set; }

        [ForeignKey("Supplier")]
        public int SID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public DateTime Date { get; set; } 
        public ICollection<TransferItem> TransferItems { get; set; } 
    }
}
