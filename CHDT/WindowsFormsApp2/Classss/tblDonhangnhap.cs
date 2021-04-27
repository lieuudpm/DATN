using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
   public class tblDonhangnhap
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
     
        public List<ct_sanpham> getLstChiTietSanPham()
        {
            List<ct_sanpham> lstChiTietSanPham = dl.ct_sanpham.ToList();
            return lstChiTietSanPham;
        }
        public bool add(ct_sanpham chiTietSanPham)
        {
            dl.ct_sanpham.Add(chiTietSanPham);
            dl.SaveChanges();
            return true;
        }
        public bool update(ct_sanpham chiTietSanPham)
        {
            dl.ct_sanpham.Add(chiTietSanPham);
            dl.SaveChanges();
            return true;
        }
    }
}
