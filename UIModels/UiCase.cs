﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UiCase
    {
        [Key]
        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool CaseClosed { get; set; }
        // Navigations properties
        public virtual UiEmployee Employee { get; set; }
        public virtual UiClient Client { get; set; } 
        public virtual List<AppliedService>? AppliedServices { get; set; }
    }
}