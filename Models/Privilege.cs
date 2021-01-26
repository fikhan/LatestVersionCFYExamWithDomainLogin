using System;
using System.Collections.Generic;

#nullable disable

namespace CFY_Exam.Models
{
    public partial class Privilege
    {
        public long PriviligesId { get; set; }
        public string PriviligeCode { get; set; }
        public string PriviligeName { get; set; }
        public int PriviligeType { get; set; }
        public int Status { get; set; }
        public string FirstUserName { get; set; }
        public DateTime FirstTimeStamp { get; set; }
        public string LastUserName { get; set; }
        public DateTime? LastTimeStamp { get; set; }
    }
}
