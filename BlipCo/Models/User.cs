using System;

namespace BlipCo.Models
{
    public class User
    {
        public string UserID { get; set; }

        public string Username { get; set; }

        public string TermsStatus { get; set; }

        public DateTime AcceptedOn { get; set; }
    }
}