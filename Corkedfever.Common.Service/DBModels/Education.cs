using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corkedfever.Common.Data.DBModels
{
    public class Education
    { 
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Degree { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }
        public DateTime GraduationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
