using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace ProjectWarehouse.Files
{
    class Warehouse
    {
        public Warehouse() 
        {
            SupplyPermits = new HashSet<SupplyPermit>();
            WithdrawPermit = new HashSet<WithdrawPermit>();
            TransfersFrom = new HashSet<Transfer>();
            TransfersTo = new HashSet<Transfer>();
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Manager { get; set; }

        public ICollection<SupplyPermit> SupplyPermits { get; set; }
        public ICollection<WithdrawPermit> WithdrawPermit { get; set; }
        public ICollection<Transfer> TransfersFrom { get; set; }
        public ICollection<Transfer> TransfersTo { get; set; }
    }
}
