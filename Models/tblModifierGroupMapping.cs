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
    
    public partial class tblModifierGroupMapping
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblModifierGroupMapping()
        {
            this.tblGSRequestsModifierMappings = new HashSet<tblGSRequestsModifierMapping>();
        }
    
        public int id { get; set; }
        public Nullable<int> fkModifierGroupid { get; set; }
        public Nullable<int> fkModifierid { get; set; }
        public string status { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGSRequestsModifierMapping> tblGSRequestsModifierMappings { get; set; }
        public virtual tblModifier tblModifier { get; set; }
        public virtual tblModifierGroup tblModifierGroup { get; set; }
    }
}
