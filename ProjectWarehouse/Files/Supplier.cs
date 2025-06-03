using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class Supplier
    {
        public Supplier() 
        {
            SupplyPermits = new HashSet<SupplyPermit>();
            Transfers = new HashSet<Transfer>();
        }
        [Key] public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public ICollection<SupplyPermit> SupplyPermits { get; set; }
        public ICollection<Transfer> Transfers { get; set; }
    }
}
