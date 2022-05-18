using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Oblast
    {
        public Oblast()
        {
            Interes = new HashSet<Intere>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Intere> Interes { get; set; }
    }
}
