using System;

namespace FontesBank.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public float CurrentBalance { get; set; }
        public string Address { get; set; }

    }
}
