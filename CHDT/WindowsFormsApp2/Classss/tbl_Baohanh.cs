﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
   public class tbl_Baohanh
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        public List<ct_baohanh> getLstChitietaohanh()
        {
            return dl.ct_baohanh.ToList();
        }
         public bool add(ct_baohanh chitietbaohanh)
        {
            dl.ct_baohanh.Add(chitietbaohanh);
            dl.SaveChanges();
            return true;
        }
    }
}
