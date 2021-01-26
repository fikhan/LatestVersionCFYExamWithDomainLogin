using System;
using System.Collections.Generic;

#nullable disable

namespace CFY_Exam.Models
{
    public partial class UserGroup
    {
        public int UserGroupId { get; set; }
        public string UserGroupCode { get; set; }
        public string GroupName { get; set; }
        public int Status { get; set; }
        public string FirstUserName { get; set; }
        public DateTime FirstTimeStamp { get; set; }
        public string LastUserName { get; set; }
        public DateTime? LastTimeStamp { get; set; }
    }
}
