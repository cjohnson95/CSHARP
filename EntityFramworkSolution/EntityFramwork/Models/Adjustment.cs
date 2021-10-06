using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFramwork.Models
{
    public partial class Adjustment
    {
        public int Id { get; set; }
        public string Fisrtname { get; set; }
        public string Lastname { get; set; }
        public decimal Gpadelta { get; set; }
        public bool Completed { get; set; }
    }
}
