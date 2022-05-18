using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Potrebitelintere
    {
        public int PotrebitelId { get; set; }
        public int InteresId { get; set; }

        public virtual Intere Potrebitel { get; set; }
        public virtual Potrebitel PotrebitelNavigation { get; set; }
    }
}
