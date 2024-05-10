using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LawyerEducation // <---------------- Working progress, mange-til-mange relation SKAL håndteres!
    {
        public int LawyerId { get; set; }
        public int EducationId { get; set; }


    }
}

