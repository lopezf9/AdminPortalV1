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
    
    public partial class tblScreenPageCategory
    {
        public int id { get; set; }
        public string pageName { get; set; }
        public string description { get; set; }
        public int pageindex { get; set; }
        public string status { get; set; }
        public int fkScreenId { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        public virtual tblScreen tblScreen { get; set; }
    }
}
