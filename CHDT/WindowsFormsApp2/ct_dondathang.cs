//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ct_dondathang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ct_dondathang()
        {
            this.ct_baohanh = new HashSet<ct_baohanh>();
        }
    
        public int mactddh { get; set; }
        public Nullable<int> maddh { get; set; }
        public Nullable<int> mactsp { get; set; }
        public string tensp { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<long> giaban { get; set; }
        public string thoigianbatdau { get; set; }
        public string thoigianketthuc { get; set; }
        public Nullable<int> tinhtrang { get; set; }
        public string soserial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ct_baohanh> ct_baohanh { get; set; }
        public virtual ct_sanpham ct_sanpham { get; set; }
        public virtual dondathang dondathang { get; set; }
    }
}
