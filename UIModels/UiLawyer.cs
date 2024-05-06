using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UiLawyer : UiEmployee
    {
        public virtual List<UiAppliedService>? AppliedServices { get; set; }
        public virtual List<UiEducation>? Educations { get; set; }
    }
}