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
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Consignees = new HashSet<Consignee>();
            this.Log_OrderDetail = new HashSet<Log_OrderDetail>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int idOrder { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> DeliveryType { get; set; }
        public Nullable<bool> PaymentType { get; set; }
        public Nullable<System.DateTime> EstimateDateOfDelivery { get; set; }
        public Nullable<byte> Statuses { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> idDistributor { get; set; }
        public Nullable<int> idConsignee { get; set; }
        public Nullable<int> idStaff { get; set; }
        public string Descriptions { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consignee> Consignees { get; set; }
        public virtual Consignee Consignee { get; set; }
        public virtual DeliveryOrder DeliveryOrder { get; set; }
        public virtual Distributor Distributor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_OrderDetail> Log_OrderDetail { get; set; }
        public virtual Staff Staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}