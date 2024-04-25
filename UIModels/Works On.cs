using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UIWorks_On
    {
        [Column(Order = 0)]
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public virtual UIService Service { get; set; }

        [Column(Order = 1)]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual UIEmployee Employee { get; set; }

        public int HoursSpent { get; set; }

        public double DistanceTraveledByEmployee { get; set; }
    }
}