﻿using System;
using System.Collections.Generic;

namespace ProjectPRN211.Models
{
    public partial class IncomeType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
