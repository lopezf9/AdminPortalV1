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
    
    public partial class tblRSCategoriesTiming
    {
        public int id { get; set; }
        public string day { get; set; }
        public System.TimeSpan starttime { get; set; }
        public System.TimeSpan endtime { get; set; }
        public int fkItemCategoryid { get; set; }
        public string status { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        public virtual tblItemCategory tblItemCategory { get; set; }
    }
}