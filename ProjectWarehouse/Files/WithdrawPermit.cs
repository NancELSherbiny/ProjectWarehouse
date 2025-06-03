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
        public int ID { get; set; } 
        [ForeignKey("Warehouse")]
        public int WID { get; set; } 
        public virtual Warehouse Warehouse { get; set; } 
        [ForeignKey("Client")]
        public int CID { get; set; }
        public virtual Client Client { get; set; } 
        public DateTime Date { get; set; } 
        public ICollection<WithdrawPermitItem> withdrawPermitItems { get; set; } 

    }
}
