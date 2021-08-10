using System;

namespace FontesBank.Models
{
    public class TransferModel
    {
        public string UserToId { get; set; }
        public string UserFromId { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }

    }
}
