using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
   public class tblHangsanxuat
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        public static string Mahangsx = null;
        public static string Tenhangsx = null;
        public List<hang> getLstHang()
        {
            List<hang> lstHangsanxuat = dl.hangs.ToList();
            return lstHangsanxuat;
        }
        public int add(int maHang, string tenHang)
        {
            hang Hangsx = new hang();
            Hangsx.mahang = maHang;
            Hangsx.tenhang = tenHang;
            dl.hangs.Add(Hangsx);
            return dl.SaveChanges();
        }
        public int Delete( int id)
        {
            hang Hangsx = dl.hangs.First(c => c.mahang == id);
            dl.hangs.Remove(Hangsx);
            return dl.SaveChanges();

        }
        public int update(int maHang, string tenhangsx)
        {
            hang hangsanxuat = dl.hangs.First(c => c.mahang == maHang);
            hangsanxuat.tenhang = tenhangsx;
            return dl.SaveChanges();
        }
    }
}
