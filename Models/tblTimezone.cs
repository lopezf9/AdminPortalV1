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
    
    public partial class tblTimezone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTimezone()
        {
            this.tblHotels = new HashSet<tblHotel>();
        }
    
        public int id { get; set; }
        public string tzid { get; set; }
        public string tzname { get; set; }
        public string jtzid { get; set; }
        public string offset { get; set; }
        public string usedaylight { get; set; }
        public string dstsavings { get; set; }
        public string displayname { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHotel> tblHotels { get; set; }
    }
}
