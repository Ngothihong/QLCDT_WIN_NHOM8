using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF;
namespace WebQLCDT.DAL
{
    public class DAL_Thongtinsim
    {
        public List<THONGTINSIM> GetbySDT(string Sim)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var thongtinsim1 = from x in db.THONGTINSIMs
                               where x.Sdt == Sim
                               orderby x.IDSim descending
                               select x;
            return thongtinsim1.ToList();

        }
    }
}