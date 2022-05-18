using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Oblast
    {
        public Oblast()
        {
            Interesis = new HashSet<Interesi>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Interesi> Interesis { get; set; }
    }
}
