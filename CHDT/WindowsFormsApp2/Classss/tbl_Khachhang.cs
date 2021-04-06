using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
   public class tbl_Khachhang
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        public List<khachhang> getLstKhachhang()
        {
            return dl.khachhangs.ToList();
        }
    }
}
