using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Base_User
    {
        public int ID { get; set; }
        public string realName { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string mobilePhone { get; set; }
        public Nullable<int> isUse { get; set; }
        public Nullable<int> userType { get; set; }
        public string companyName { get; set; }
        public string companyAddress { get; set; }
        public string companyCity { get; set; }
        public string postCode { get; set; }
        public string notes { get; set; }
    }
}
