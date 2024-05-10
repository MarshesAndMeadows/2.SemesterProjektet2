using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Zipcode
    {
        public int Id { get; set; }
        [MaxLength(4)]
        public string Postal { get; set; }
        public string City { get; set; }
    }
}