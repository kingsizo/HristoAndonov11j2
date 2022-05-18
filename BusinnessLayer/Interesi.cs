using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Interesi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OblastId { get; set; }

        public virtual Oblast Oblast { get; set; }
    }
}
