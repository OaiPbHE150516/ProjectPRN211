using System;
using System.Collections.Generic;

namespace ProjectPRN211.Models
{
    public partial class User
    {
        public User()
        {
            Money = new HashSet<Money>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Money> Money { get; set; }
    }
}
