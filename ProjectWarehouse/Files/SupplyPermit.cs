using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class SupplyPermit
    {
        public SupplyPermit()
        {
            supplyPermitItems = new HashSet<SupplyPermitItem>();
        }
        [Key]
        public int ID { get; set; }

        [ForeignKey("Warehouse")]
        public int WID { get; set; }
        public virtual Warehouse Warehouse { get; set; }

        [ForeignKey("Supplier")]
        public int SID { get; set; }
        public virtual Supplier Supplier { get; set; }
        public DateTime Date { get; set; }

        public ICollection<SupplyPermitItem> supplyPermitItems { get; set; } 
    }
}
