using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Sys_Lcode
    {
        public int ID { get; set; }
        public string listCode { get; set; }
        public string listName { get; set; }
        public string picAddress { get; set; }
        public string linkAddress { get; set; }
        public string linkLevel { get; set; }
        public string parentID { get; set; }
        public string depth { get; set; }
        public Nullable<int> flag { get; set; }
    }
}
