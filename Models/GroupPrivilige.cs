using System;
using System.Collections.Generic;

#nullable disable

namespace CFY_Exam.Models
{
    public partial class GroupPrivilige
    {
        public long GroupPriviligeId { get; set; }
        public long PriviligesId { get; set; }
        public int UserGroupId { get; set; }
    }
}
