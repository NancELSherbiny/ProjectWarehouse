using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class ItemUnit
    {
        public ItemUnit()
        {
            Items = new HashSet<Item>();
        }
        [Key] public int ItemID { get; set; }
        public string Unit { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
