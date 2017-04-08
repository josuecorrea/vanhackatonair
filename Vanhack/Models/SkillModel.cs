using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vanhack.Models
{
    public class SkillModel
    {
        public int Id { get; set; }

        public string SkillName { get; set; }

        public bool Active { get; set; }

        public DateTime? ApprovalDate { get; set; }
    }
}