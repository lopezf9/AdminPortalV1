//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminPortalV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblGuestPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGuestPackage()
        {
            this.tblPackageViewHistories = new HashSet<tblPackageViewHistory>();
            this.tblVODdisputes = new HashSet<tblVODdispute>();
        }
    
        public int id { get; set; }
        public string purchasetype { get; set; }
        public int fkGuestid { get; set; }
        public int fkHotelPackageid { get; set; }
        public float price { get; set; }
        public string currency { get; set; }
        public string producttype { get; set; }
        public string paymentmethod { get; set; }
        public string contentprovider { get; set; }
        public string category { get; set; }
        public string serviceid { get; set; }
        public string externalid { get; set; }
        public string movietitle { get; set; }
        public System.DateTime pstarttime { get; set; }
        public System.DateTime pendtime { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
        public string PurchaseID { get; set; }
    
        public virtual tblHotelPackage tblHotelPackage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPackageViewHistory> tblPackageViewHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVODdispute> tblVODdisputes { get; set; }
    }
}
