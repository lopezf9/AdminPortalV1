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
    
    public partial class tblLocalAttractionMapping
    {
        public int id { get; set; }
        public Nullable<int> fkAmenityid { get; set; }
        public Nullable<int> fkHotelLocalAttractionid { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        public virtual tblAmenity tblAmenity { get; set; }
        public virtual tblHotelLocalAttraction tblHotelLocalAttraction { get; set; }
    }
}
