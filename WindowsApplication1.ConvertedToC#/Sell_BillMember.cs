//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sell_BillMember
    {
        public long S_ID { get; set; }
        public int MID { get; set; }
        public string P_ID { get; set; }
        public Nullable<System.DateTime> S_Date { get; set; }
        public Nullable<System.TimeSpan> S_Time { get; set; }
    
        public virtual Member_Detail Member_Detail { get; set; }
        public virtual Package Package { get; set; }
    }
}
