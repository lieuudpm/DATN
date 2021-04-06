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
        public List<donhangnhap> getLstDonhangnhap()
        {
            List<donhangnhap> lstDonhangnhap = dl.donhangnhaps.ToList();
            return lstDonhangnhap;
        }
    }
}
