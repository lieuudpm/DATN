using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
  public  class tblSanpham
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        public List<sanpham> getLstSanpham()
        {
            return dl.sanphams.ToList();
        }

        public bool add(sanpham Sanpham)
        {
            dl.sanphams.Add(Sanpham);
            dl.SaveChanges();
            return true;
        }

        public bool update()
        {
            dl.SaveChanges();
            return true;
        }

    }
}
