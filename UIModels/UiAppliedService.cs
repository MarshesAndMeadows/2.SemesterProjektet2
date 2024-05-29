using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UiAppliedService
    {
        [Key]
        public int Id { get; set; }
        public string Note { get; set; }
        public int? UnitCount { get; set; }
        public double? UnitCostActual { get; set; }
        public double? StartPaymentActual { get; set; }
        public DateTime ServicePerformed { get; set; }
        // Navigations properties
        public UiService Service { get; set; }
        public UiLawyer Lawyer { get; set; }

    }
}