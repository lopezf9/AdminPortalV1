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
    
    public partial class tblGuestCoupon
    {
        public int id { get; set; }
        public int fkCouponNumberid { get; set; }
        public int fkGuestid { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        public virtual tblCouponNumber tblCouponNumber { get; set; }
        public virtual tblGuest tblGuest { get; set; }
    }
}
