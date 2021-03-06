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
    
    public partial class tblHotelPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHotelPackage()
        {
            this.tblCouponPackages = new HashSet<tblCouponPackage>();
            this.tblGuestPackages = new HashSet<tblGuestPackage>();
            this.tblRoomTypePackages = new HashSet<tblRoomTypePackage>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int fkHotelid { get; set; }
        public int fkHotelPackageTypeid { get; set; }
        public string status { get; set; }
        public System.DateTime createddatetime { get; set; }
        public System.DateTime updateddatetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCouponPackage> tblCouponPackages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGuestPackage> tblGuestPackages { get; set; }
        public virtual tblHotel tblHotel { get; set; }
        public virtual tblHotelPackageType tblHotelPackageType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRoomTypePackage> tblRoomTypePackages { get; set; }
    }
}
