using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
    public class tbl_NhanVien
    {
        db_QLCHEntities2 db = new db_QLCHEntities2();
        public List<nhanvien> getLstNhanVien()
        {
            List<nhanvien> lstNhanVien = db.nhanviens.ToList();
            return lstNhanVien;
        }
        public bool add(nhanvien nhanVien)
        {
            db.nhanviens.Add(nhanVien);
            db.SaveChanges();
            return true;
        }

        public bool update()
        {
            db.SaveChanges();
            return true;
        }

        public string getMd5(string str)
        {
            StringBuilder strMd5 = new StringBuilder();
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(str));
            for (int i = 0; i < bytes.Length; i++)
            {
                strMd5.Append(bytes[i].ToString("x2"));
            }

            return strMd5.ToString();
        }
    }
}

