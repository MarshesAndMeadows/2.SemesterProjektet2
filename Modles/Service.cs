using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double OneTimePayment { get; set; }

        public double StartPayment { get; set; }

        public double HourlyCost { get; set; }
    }
}