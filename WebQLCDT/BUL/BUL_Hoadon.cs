using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebQLCDT.DAL;
using EF;

namespace WebQLCDT.BUL
{
    public class BUL_Hoadon
    {
        DAL_Hoadon dao = new DAL_Hoadon();
        public HOADON GetByMa(String ma)
        {
            return dao.GetByMa(ma);
        }
    }
}