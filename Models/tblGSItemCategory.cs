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
    
    public partial class tblGSItemCategory
    {
        public int id { get; set; }
        public Nullable<int> fkItemCategoryid { get; set; }
        public Nullable<int> fkHotelGuestServicesid { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        public virtual tblHotelGuestService tblHotelGuestService { get; set; }
        public virtual tblItemCategory tblItemCategory { get; set; }
    }
}
