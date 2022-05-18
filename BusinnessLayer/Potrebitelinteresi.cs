using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Potrebitelinteresi
    {
        public int PotrebitelId { get; set; }
        public int InteresId { get; set; }

        public virtual Interesi Potrebitel { get; set; }
        public virtual Potrebitel PotrebitelNavigation { get; set; }
    }
}
