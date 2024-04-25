using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UICase
    {
        public int CaseId { get; set; }

        public string Name { get; set; }

        public DateOnly EstimatedEndDate { get; set; }

        public DateOnly StartDate { get; set; }

        public bool CaseClosed { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual UIEmployee Employee { get; set; }

        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public virtual UIClient Client { get; set; }

        public virtual List<UICaseService> CaseServices { get; set; }
    }
}