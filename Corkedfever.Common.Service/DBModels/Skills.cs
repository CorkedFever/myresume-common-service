using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corkedfever.Common.Data.DBModels
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
