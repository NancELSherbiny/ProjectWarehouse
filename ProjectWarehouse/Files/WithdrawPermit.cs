using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class WithdrawPermit
    {
        public WithdrawPermit()
        {
            withdrawPermitItems = new HashSet<WithdrawPermitItem>();
        }
        [Key]
        public int ID { get; set; } // Withdraw Permit ID
        [ForeignKey("Warehouse")]
        public int WID { get; set; } // Warehouse ID
        public virtual Warehouse Warehouse { get; set; } // Navigation property to Warehouse
        [ForeignKey("Client")]
        public int CID { get; set; } // Client ID
        public virtual Client Client { get; set; } // Navigation property to Client
        public DateTime Date { get; set; } // Date of the withdraw permit
        public ICollection<WithdrawPermitItem> withdrawPermitItems { get; set; } // Collection of items in the withdraw permit

    }
}
