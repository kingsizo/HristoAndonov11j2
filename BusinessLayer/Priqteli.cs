using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Priqteli
    {
        public string FriendName { get; set; }
        public int PotrebitelId { get; set; }

        public virtual Potrebitel Potrebitel { get; set; }
    }
}
