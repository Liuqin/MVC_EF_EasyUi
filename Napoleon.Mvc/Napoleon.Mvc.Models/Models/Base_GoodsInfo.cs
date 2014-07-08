using System;
using System.Collections.Generic;

namespace Napoleon.Mvc.Models.Models
{
    public partial class Base_GoodsInfo
    {
        public int ID { get; set; }
        public string goodsName { get; set; }
        public Nullable<decimal> goodsPrices { get; set; }
        public Nullable<System.DateTime> buyDateTime { get; set; }
        public Nullable<int> buyNumber { get; set; }
        public Nullable<int> stockNumber { get; set; }
        public string notes { get; set; }
    }
}
