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
    
    public partial class tblHotelLocalAttraction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHotelLocalAttraction()
        {
            this.tblLocalAttractionMappings = new HashSet<tblLocalAttractionMapping>();
        }
    
        public int id { get; set; }
        public Nullable<int> fkHotelid { get; set; }
        public Nullable<int> fkLocalAttractionid { get; set; }
        public string status { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        public virtual tblHotel tblHotel { get; set; }
        public virtual tblLocalAttraction tblLocalAttraction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocalAttractionMapping> tblLocalAttractionMappings { get; set; }
    }
}