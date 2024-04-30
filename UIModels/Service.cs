using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace UIModels
{
    public class UIService
    {
        public int ServiceId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool OneTimePayment { get; set; }

        public double StartPayment { get; set; }

        public double HourlyCost { get; set; }
        public int CaseID { get; set; }
        public UICase UICase { get; set; }
    }
}