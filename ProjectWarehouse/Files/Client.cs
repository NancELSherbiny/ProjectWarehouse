using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWarehouse.Files
{
    class Client
    {
        public Client()
        {
            WithdrawPermit = new HashSet<WithdrawPermit>();
        }
       [Key] public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public ICollection<WithdrawPermit> WithdrawPermit { get; set; }
    }
}
