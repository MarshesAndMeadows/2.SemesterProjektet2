using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UILawyer : UIEmployee
    {
        public virtual List<UICase> Cases { get; set; }
        public string SpecializedEducation { get; set; }
    }
}