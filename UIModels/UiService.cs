using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UIModels
{
    public class UiService
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public bool OneTimePayment { get; set; }
        public double StartPaymentDefault { get; set; }
        public double UnitCostDefault { get; set; }
        // navigations properties

    }
}