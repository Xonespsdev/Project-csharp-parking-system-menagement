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
    
    public partial class Package
    {
        public Package()
        {
            this.Sell_BillMember = new HashSet<Sell_BillMember>();
        }
    
        public string P_ID { get; set; }
        public string P_Name { get; set; }
        public string P_Detail { get; set; }
        public string P_Price { get; set; }
    
        public virtual ICollection<Sell_BillMember> Sell_BillMember { get; set; }
    }
}