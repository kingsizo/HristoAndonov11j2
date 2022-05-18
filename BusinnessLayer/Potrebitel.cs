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

        public Potrebitel(int ID, string name, string familia, int vuzrast, string username, string password, string email, int oblastId)
        {
            this.Id = ID;
            this.Name = name;
            this.Familia = familia;
            this.Vuzrast = vuzrast;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.OblastId = oblastId;
        }
    }
}
