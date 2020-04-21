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
    
    public partial class tblPMSRoomMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPMSRoomMessage()
        {
            this.tblHotwireTemplateMsgPMSMsgMappings = new HashSet<tblHotwireTemplateMsgPMSMsgMapping>();
        }
    
        public int id { get; set; }
        public string readstatus { get; set; }
        public Nullable<System.DateTime> readdatetime { get; set; }
        public string messagesender { get; set; }
        public string msnumb { get; set; }
        public string prioritymessage { get; set; }
        public string groupmessage { get; set; }
        public int fkGuestId { get; set; }
        public int fkHotelRoomId { get; set; }
        public Nullable<System.DateTime> messagedatetime { get; set; }
        public string messagetext { get; set; }
        public string messagesubject { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
        public string templateBasedMsg { get; set; }
        public Nullable<System.DateTime> scheduledmsgdatetime { get; set; }
        public string ismessagedelivered { get; set; }
    
        public virtual tblGuest tblGuest { get; set; }
        public virtual tblHotelRoom tblHotelRoom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotwireTemplateMsgPMSMsgMapping> tblHotwireTemplateMsgPMSMsgMappings { get; set; }
    }
}
