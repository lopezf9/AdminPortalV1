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
    
    public partial class tblHotwireTemplateMsg
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHotwireTemplateMsg()
        {
            this.tblHotwireTemplateMsgControls = new HashSet<tblHotwireTemplateMsgControl>();
            this.tblHotwireTemplateMsgPMSMsgMappings = new HashSet<tblHotwireTemplateMsgPMSMsgMapping>();
        }
    
        public int id { get; set; }
        public string messagexml { get; set; }
        public Nullable<int> fkTemplateid { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
        public string templateImageName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotwireTemplateMsgControl> tblHotwireTemplateMsgControls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotwireTemplateMsgPMSMsgMapping> tblHotwireTemplateMsgPMSMsgMappings { get; set; }
        public virtual tblTemplate tblTemplate { get; set; }
    }
}
