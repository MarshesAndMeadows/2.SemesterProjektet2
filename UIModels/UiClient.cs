using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIModels
{
    public class UiClient
    {
        [Key]
        public int ClientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Sex { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Subscribed { get; set; }
        // Navigations properti
        public virtual List<UiCase>? Cases { get; set; }
    }
}