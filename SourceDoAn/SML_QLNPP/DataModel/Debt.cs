//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Debt
    {
        public int idDebt { get; set; }
        public Nullable<decimal> Purchase { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> idDistributor { get; set; }
        public Nullable<int> idStaff { get; set; }
    
        public virtual Distributor Distributor { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
