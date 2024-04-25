using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIModels
{
    public class UIClient
    {
        public int ClientID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public char Sex { get; set; }

        public int Age { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public bool Subscribed { get; set; }

        public int Zipcode { get; set; }

        [ForeignKey("Zipcode")]
        public virtual UIZipcode ZipcodeInfo { get; set; }
    }
}