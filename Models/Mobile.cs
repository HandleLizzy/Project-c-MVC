namespace Mobile_Affordability_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mobile
    {
        public int MobileId { get; set; }
        public string MobileBrand { get; set; }
        public string MobileType { get; set; }
        public Nullable<decimal> MobileCost { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public List<Mobile> MobileCollection { get; internal set; }
    }
}
