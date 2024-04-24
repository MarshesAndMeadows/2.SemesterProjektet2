using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Works_On
    {
        [Key, Column(Order = 0)]
        public int CaseId { get; set; }
        [ForeignKey("CaseId")]
        public virtual Case Case { get; set; }

        [Key, Column(Order = 1)]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public int HoursSpent { get; set; }

        public double DistanceTraveledByEmployee { get; set; }
    }
}