using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FontesBank.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int CurrentBalance { get; set; }
        public string Address { get; set; }

    }
}
