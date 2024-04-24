using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public bool Subscribed { get; set; }
    }
}