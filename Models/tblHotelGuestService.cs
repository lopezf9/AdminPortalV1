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
    
    public partial class tblHotelGuestService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHotelGuestService()
        {
            this.tblGSItemCategories = new HashSet<tblGSItemCategory>();
            this.tblGuestServiceRequests = new HashSet<tblGuestServiceRequest>();
            this.tblModifierGroupGSItemsMappings = new HashSet<tblModifierGroupGSItemsMapping>();
        }
    
        public int id { get; set; }
        public string itemname { get; set; }
        public string itemcode { get; set; }
        public string description { get; set; }
        public Nullable<float> price { get; set; }
        public string currency { get; set; }
        public string enabled { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public Nullable<System.DateTime> enddate { get; set; }
        public int fkHotelid { get; set; }
        public int fkGuestServiceTypeid { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
        public string itemthumbnail { get; set; }
        public int sequence { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGSItemCategory> tblGSItemCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGuestServiceRequest> tblGuestServiceRequests { get; set; }
        public virtual tblHotel tblHotel { get; set; }
        public virtual tblHotelGuestServiceType tblHotelGuestServiceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblModifierGroupGSItemsMapping> tblModifierGroupGSItemsMappings { get; set; }
    }
}
