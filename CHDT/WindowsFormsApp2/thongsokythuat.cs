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
    
    public partial class thongsokythuat
    {
        public int matskt { get; set; }
        public string ten { get; set; }
        public string thongsokythuat1 { get; set; }
        public Nullable<int> masp { get; set; }
        public Nullable<int> sothutu { get; set; }
        public Nullable<int> malts { get; set; }
        public Nullable<int> idparent { get; set; }
        public Nullable<int> isdefault { get; set; }
    
        public virtual loaithongso loaithongso { get; set; }
        public virtual sanpham sanpham { get; set; }
    }
}
