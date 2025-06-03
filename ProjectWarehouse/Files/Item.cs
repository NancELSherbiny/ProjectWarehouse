using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class Item
    {
        public Item()
        {
            SupplyPermitItem = new HashSet<SupplyPermitItem>();
            WithdrawPermitItem = new HashSet<WithdrawPermitItem>();
            TransferItem = new HashSet<TransferItem>();
        }
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("ItemUnit")]
        public int ItemUnitID { get; set; }
        public virtual ItemUnit ItemUnit { get; set; }

        public ICollection<SupplyPermitItem> SupplyPermitItem { get; set; }
        public ICollection<WithdrawPermitItem> WithdrawPermitItem { get; set; }
        public ICollection<TransferItem> TransferItem { get; set; }
    }
}
