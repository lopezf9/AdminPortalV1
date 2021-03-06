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
    
    public partial class tblGuestServiceRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGuestServiceRequest()
        {
            this.tblGSRequestsModifierMappings = new HashSet<tblGSRequestsModifierMapping>();
            this.tblGSRequestsModifierMapping_22 = new HashSet<tblGSRequestsModifierMapping_22>();
            this.tblGSRequestStatus = new HashSet<tblGSRequestStatu>();
        }
    
        public int id { get; set; }
        public int fkHotelGuestServicesid { get; set; }
        public int fkGuestid { get; set; }
        public System.DateTime requestedtime { get; set; }
        public string requeststatus { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
        public int qty { get; set; }
        public string deviceExternalID { get; set; }
        public string hasFoodAllergy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGSRequestsModifierMapping> tblGSRequestsModifierMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGSRequestsModifierMapping_22> tblGSRequestsModifierMapping_22 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGSRequestStatu> tblGSRequestStatus { get; set; }
        public virtual tblGuest tblGuest { get; set; }
        public virtual tblHotelGuestService tblHotelGuestService { get; set; }
    }
}
