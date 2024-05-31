using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UIModels
{
    public class UiCase
    {
        [Key]
        public int Id { get; set; }
        public string CaseName { get; set; }
        public string CaseDescription { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool CaseClosed { get; set; }
        // Navigations properties
        public UiEmployee Employee { get; set; }
        public UiClient Client { get; set; } 
        public List<UiAppliedService>? AppliedServices { get; set; }
    }
}