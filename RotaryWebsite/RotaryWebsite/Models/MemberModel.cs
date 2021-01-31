using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotaryWebsite.Models
{
    public class MemberModel
    {
        public int memberId { get; set; }
        public int chapterId { get; set; }
        public string title { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string image { get; set; }
        public string membernumber { get; set; }
        public string position { get; set; }
        public int city { get; set; }
        public string mobile1  { get; set; }
        public string mobile2 { get; set; }
        public string mobile3 { get; set; }
        public string emailid { get; set; }
        public string dob { get; set; }
        public string dom { get; set; }
        public bool IsActive { get; set; }
        public string classification { get; set; }
        public string imageL { get; set; }
        public string title2 { get; set; }
        public string membersince { get; set; }

    }
}
