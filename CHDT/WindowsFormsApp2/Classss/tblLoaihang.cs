using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
   public class tblLoaihang
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        public static string Maloaihang = null;
        public static string Tenloaihang = null;
        public List<loaihang> getLstLoaihang()
        {
            List<loaihang> lstLoaihang = dl.loaihangs.ToList();
            return lstLoaihang;
        }

        public int add( int maloaihang, string tenloaihang)
        {
            loaihang tblLoaihang = new loaihang();
            tblLoaihang.maloai = maloaihang;
            tblLoaihang.tenloai = tenloaihang;
            dl.loaihangs.Add(tblLoaihang);
            return dl.SaveChanges();
        }

        public int update(int maLoai, string tenLoai)
        {
            loaihang lblLoaihang = dl.loaihangs.First(c => c.maloai == maLoai);
            lblLoaihang.tenloai = tenLoai;
            return dl.SaveChanges();
        }
        public bool delete(string Maloai)
        {
            try
            {
                loaihang tblLoaihang = dl.loaihangs.First(c => c.maloai ==int.Parse(Maloai));
                dl.loaihangs.Remove(tblLoaihang);
                dl.SaveChanges();
                return true;
            }
            catch
            {
                dl = new db_QLCHEntities2();
                return false;
            }
        }
    }
}
