using System;

namespace SmartBirthClient.Models
{
    public class BirthRegistration
    {
        public int BirthRegistrationCode { get; set; }
        public string NewbornName { get; set; }
        public DateTime BirthDate { get; set; }

        public int Parent1Code { get; set; }
        public int Parent2Code { get; set; }
    }
}