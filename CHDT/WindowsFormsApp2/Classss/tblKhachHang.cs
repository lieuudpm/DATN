using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
   public class tblKhachHang
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        public List<khachhang> getLstKhachHang()
        {
            return  dl.khachhangs.ToList();
        }
        public bool add(khachhang khachHang)
        {
           dl.khachhangs.Add(khachHang);
           dl.SaveChanges();
            return true;
        }
    }
}
