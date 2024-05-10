using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Education
    {
        public Education()
        {
            lawyer = new List<Lawyer>();
        }
        public int Id { get; set; }
        public string EducationName { get; set; }
        public string Description { get; set; }
        public List<Lawyer> lawyer { get; set; }       
    }
}
