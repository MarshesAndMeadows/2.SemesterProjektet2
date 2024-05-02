using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UiLawyer : UiEmployee
    {
        public virtual List<AppliedService>? AppliedServices { get; set; }
        public virtual List<UiEducation>? Educations { get; set; }
    }
}