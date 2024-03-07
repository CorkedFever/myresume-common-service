using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corkedfever.Common.Data.DBModels
{
    public class Certification
    {
        public int Id { get; set; }
        public string CertificationName { get; set; }
        public string CertificationDescription { get; set; }
        public CertificationType CertificationType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
