using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Potrebitel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Familia { get; set; }
        public int Vuzrast { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? OblastId { get; set; }
    }
}
