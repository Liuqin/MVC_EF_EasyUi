using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Sys_Xcode
    {
        public int ID { get; set; }
        public string codeSelf { get; set; }
        public string codeRule { get; set; }
        public string name { get; set; }
        public string remark { get; set; }
        public Nullable<int> sort { get; set; }
        public Nullable<int> parentID { get; set; }
        public string depth { get; set; }
        public string flag { get; set; }
    }
}
