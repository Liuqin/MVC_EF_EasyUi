using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Base_Company
    {
        public int ID { get; set; }
        public string companyName { get; set; }
        public string companyPerson { get; set; }
        public string companyPhone { get; set; }
        public string mobilePhone { get; set; }
        public string personPostion { get; set; }
        public string companyAddress { get; set; }
        public string companyCity { get; set; }
        public string postCode { get; set; }
        public string nsrXz { get; set; }
        public string notes { get; set; }
    }
}
