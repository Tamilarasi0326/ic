//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iCECREAMPROJECT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_MEMBERSHIP
    {
        public TBL_MEMBERSHIP()
        {
            this.tbl_user = new HashSet<tbl_user>();
        }
    
        public int MEM_ID { get; set; }
        public string MEM_TYPE { get; set; }
        public Nullable<int> MEM_PAYMENT { get; set; }
    
        public virtual ICollection<tbl_user> tbl_user { get; set; }
    }
}
