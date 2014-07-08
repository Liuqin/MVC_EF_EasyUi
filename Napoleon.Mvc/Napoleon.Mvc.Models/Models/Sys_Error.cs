using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Sys_Error
    {
        public int ID { get; set; }
        public string stackTrace { get; set; }
        public string targetSite { get; set; }
        public string userName { get; set; }
        public Nullable<System.DateTime> errorTime { get; set; }
    }
}
