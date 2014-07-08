using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Base_ManProjects
    {
        public int ID { get; set; }
        public string userId { get; set; }
        public Nullable<int> projectId { get; set; }
        public Nullable<System.DateTime> startDateTime { get; set; }
        public Nullable<System.DateTime> endDateTime { get; set; }
        public string notes { get; set; }
    }
}
