using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF;

namespace WebQLCDT.DAL
{
    public class DAL_Hoadon
    {
        public HOADON GetByMa(String ma)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.HOADONs.Where(a => a.IDHD == ma).SingleOrDefault();
        }
    }
}