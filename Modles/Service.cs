using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool OneTimePayment { get; set; }

        public double StartPayment { get; set; }

        public double HourlyCost { get; set; }

        public virtual List<CaseService> CaseServices { get; set; }
    }
}