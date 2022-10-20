using System;
using System.Collections.Generic;

namespace ProjectPRN211.Models
{
    public partial class Money
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Cash { get; set; }
        public decimal Bank { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
