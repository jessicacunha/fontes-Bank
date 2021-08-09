using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FontesBank.Models
{
    public class TransferModel
    {
        public string UserToId { get; set; }
        public string UserFromId { get; set; }
        public string Amount { get; set; }
    }
}
