using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF;


namespace WebQLCDT.DAL
{
    public class DAL_thoigiansudung
    {
        public List<THOIGIANSUDUNG> GetAll()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.THOIGIANSUDUNGs.ToList();
        }
        public List<THOIGIANSUDUNG> GebyIDSIM(int SIM)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.THOIGIANSUDUNGs.Where(x => x.IDSim == SIM).ToList();
        }
        public List<THOIGIANSUDUNG> Get_by_hoadon(HOADON a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var abc = (from thsd in db.THOIGIANSUDUNGs
                       where (thsd.IDSim == a.IDsim) && (thsd.TGBD >= a.TGBD) && (thsd.TGBD <= a.TGKT)
                       select thsd);

            return abc.ToList();
        }
    }
}