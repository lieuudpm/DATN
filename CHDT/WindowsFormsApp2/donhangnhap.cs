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
    
    public partial class donhangnhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public donhangnhap()
        {
            this.ct_donhangnhap = new HashSet<ct_donhangnhap>();
        }
    
        public int madhn { get; set; }
        public Nullable<int> manv { get; set; }
        public Nullable<int> mancc { get; set; }
        public Nullable<System.DateTime> ngaynhaphang { get; set; }
        public string trangthai { get; set; }
        public string ghichu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ct_donhangnhap> ct_donhangnhap { get; set; }
        public virtual nhacungcap nhacungcap { get; set; }
        public virtual nhanvien nhanvien { get; set; }
    }
}
