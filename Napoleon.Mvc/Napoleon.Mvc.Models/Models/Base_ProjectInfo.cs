using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Base_ProjectInfo
    {
        public int ID { get; set; }
        public Nullable<int> companyID { get; set; }
        public string userID { get; set; }
        public string projectName { get; set; }
        public Nullable<System.DateTime> contractDate { get; set; }
        public Nullable<decimal> projectCost { get; set; }
        public Nullable<System.DateTime> projectCostEndDate { get; set; }
        public Nullable<System.DateTime> invoiceDate { get; set; }
        public string projectCostInfo { get; set; }
        public string notes { get; set; }
    }
}
