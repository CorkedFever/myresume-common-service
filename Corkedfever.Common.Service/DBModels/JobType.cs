using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corkedfever.Common.Data.DBModels
{
    public class JobType
    {
        public int Id { get; set; }
        public string JobTypeName { get; set; }
        public string JobTypeDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
