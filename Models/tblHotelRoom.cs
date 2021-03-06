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
    
    public partial class tblHotelRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHotelRoom()
        {
            this.tblGuestRoomMappings = new HashSet<tblGuestRoomMapping>();
            this.tblHotwireRoomMessages = new HashSet<tblHotwireRoomMessage>();
            this.tblPMSRoomMessages = new HashSet<tblPMSRoomMessage>();
            this.tblRoomCleanStatus = new HashSet<tblRoomCleanStatu>();
            this.tblRoomSTBs = new HashSet<tblRoomSTB>();
            this.tblSubscriberServices = new HashSet<tblSubscriberService>();
            this.tblHotelVLANDetails = new HashSet<tblHotelVLANDetail>();
        }
    
        public int id { get; set; }
        public string subscriberId { get; set; }
        public string roomnumber { get; set; }
        public string description { get; set; }
        public int floornumber { get; set; }
        public string roomstatus { get; set; }
        public int importStatusFlag { get; set; }
        public int fkHotelid { get; set; }
        public int fkRoomTypeid { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
        public string notes { get; set; }
        public string enableCasting { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGuestRoomMapping> tblGuestRoomMappings { get; set; }
        public virtual tblHotel tblHotel { get; set; }
        public virtual tblRoomType tblRoomType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotwireRoomMessage> tblHotwireRoomMessages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPMSRoomMessage> tblPMSRoomMessages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRoomCleanStatu> tblRoomCleanStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRoomSTB> tblRoomSTBs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubscriberService> tblSubscriberServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotelVLANDetail> tblHotelVLANDetails { get; set; }
    }
}
