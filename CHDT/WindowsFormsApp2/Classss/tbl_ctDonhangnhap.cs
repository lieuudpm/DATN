﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Classss
{
    public class tbl_ctDonhangnhap
    {
        db_QLCHEntities2 dl = new db_QLCHEntities2();
        public List<ct_donhangnhap> getLstCTDonhangnhap()
        {
            return dl.ct_donhangnhap.ToList();
        }
    }
}
