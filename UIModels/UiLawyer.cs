using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UiLawyer : UiEmployee
    {
        public List<UiAppliedService>? AppliedServices { get; set; }
        public List<UiEducation>? Educations { get; set; }

        public override string ToString()
        {
            return Firstname +" "+Lastname;
        }
    }
}