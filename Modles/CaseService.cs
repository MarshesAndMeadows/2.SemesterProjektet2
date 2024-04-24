using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CaseService
    {
        [Key]
        [Column(Order = 1)]
        public int CaseId { get; set; }
        [ForeignKey("CaseId")]
        public virtual Case Case { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }
    }
}