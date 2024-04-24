using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Zipcode
    {
        [Key]
        public int Postal { get; set; }

        public string City { get; set; }
    }
}