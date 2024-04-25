using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UICaseService
    {
        [Column(Order = 1)]
        public int CaseId { get; set; }
        [ForeignKey("CaseId")]
        public virtual UICase Case { get; set; }

        [Column(Order = 2)]
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public virtual UIService Service { get; set; }
    }
}