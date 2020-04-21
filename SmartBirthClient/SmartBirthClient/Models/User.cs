using System;
using System.Collections.Generic;

namespace SmartBirthClient.Models
{
    public class User
    {
        public int UserCode { get; set; }
        public string Name { get; set; }
        public long Rg { get; set; }
        public long Cpf { get; set; }
        public DateTime Birth { get; set; }

        public List<BirthRegistration> Heirs { get; set; }

        public User()
        {
            this.Heirs = new List<BirthRegistration>();
        }
    }
}