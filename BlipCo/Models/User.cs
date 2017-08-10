using System;

namespace BlipCo.Models
{
    public class User
    {
        public Guid UserID { get; set; }

        public string Username { get; set; }

        public string TermsStatus { get; set; }

        public DateTime Accepted { get; set; }

        public DateTime Reminder { get; set; }
    }
}