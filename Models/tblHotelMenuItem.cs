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
    
    public partial class tblHotelMenuItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHotelMenuItem()
        {
            this.tblHotelMenuItemLanguageMappings = new HashSet<tblHotelMenuItemLanguageMapping>();
            this.tblHotelMenuItemParentChildMappings = new HashSet<tblHotelMenuItemParentChildMapping>();
            this.tblHotelMenuItemParentChildMappings1 = new HashSet<tblHotelMenuItemParentChildMapping>();
        }
    
        public int id { get; set; }
        public int fkHotelid { get; set; }
        public int fkMenuItemid { get; set; }
        public string on_image { get; set; }
        public string off_image { get; set; }
        public string active_image { get; set; }
        public string status { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        public virtual tblHotel tblHotel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotelMenuItemLanguageMapping> tblHotelMenuItemLanguageMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotelMenuItemParentChildMapping> tblHotelMenuItemParentChildMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotelMenuItemParentChildMapping> tblHotelMenuItemParentChildMappings1 { get; set; }
        public virtual tblMenuItem tblMenuItem { get; set; }
    }
}
