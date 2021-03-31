using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
    public class ttTaiKhoan
    {
        private static nhanvien nv;
        public static void set(nhanvien _nv)
        {
            nv = _nv;
        }
        public static nhanvien get()
        {
            return nv;
        }
    }
}
