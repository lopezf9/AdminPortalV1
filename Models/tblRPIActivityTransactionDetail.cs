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
    
    public partial class tblRPIActivityTransactionDetail
    {
        public int id { get; set; }
        public string activitystatus { get; set; }
        public string activityresponse { get; set; }
        public int fkHotelVLANDetailsRPIid { get; set; }
        public int fkRPIActivityTransactionid { get; set; }
        public System.DateTime startdatetime { get; set; }
        public System.DateTime enddatetime { get; set; }
    
        public virtual tblHotelVLANDetail tblHotelVLANDetail { get; set; }
        public virtual tblRPIActivityTransaction tblRPIActivityTransaction { get; set; }
    }
}
