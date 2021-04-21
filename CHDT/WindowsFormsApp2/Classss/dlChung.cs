using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
    public class dlChung
    {
        // public static string url = "frmDangnhap";
        public static bool thoatCT = true;
        public static string gioiTinhNamValue = "NA";
        public static string gioiTinhNuValue = "NU";
      

        public static string gioiTinhLabel(string val)
        {
            //nu-Nữ - na-Nam
            return val.ToUpper() == gioiTinhNuValue ? "Nữ" : "Nam";
        }

        public static bool isGoiTinhNam(string val)
        {
            //nu-Nữ - na-Nam
            return val.ToUpper() == gioiTinhNamValue;
        }

        public static bool isGoiTinhNu(string val)
        {
            //nu-Nữ - na-Nam
            return val.ToUpper() == gioiTinhNuValue;
        }

        public static bool isHoatDong(int? val)
        {
            // 0: k hoạt đông ; 1: hoạt động 
            return val == 1;
        }


        public static string quyenHanLabel(int? val)
        {
            string strQuyenHan = "";
            if (val == 0)
            {
                strQuyenHan = "Admin";
            }
            else if (val == 1)
            {
                strQuyenHan = "Nhân viên bán hàng ";
            }
            else if (val == 2)
            {
                strQuyenHan = "Nhân viên kế toán";
            }
            else if (val == 3)
            {
                strQuyenHan = "Nhân viên kho ";
            }
            return strQuyenHan;
        }
        public static string TrangThaiLabel(int ? val)
        {
            string strTrangThai = "";
            if (val == 0)
            {
                strTrangThai = "Đã tiếp nhận";
            }
            else if (val == 1)
            {
                strTrangThai = "Đã thanh toán";
            }
            else if (val == 2)
            {
                strTrangThai = "Đã hủy";
            }
            return strTrangThai;
        }
     
    }
}
