using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebQLCDT.DAL;
using EF;

namespace WebQLCDT.BUL
{
    public class BUL_Thoigiansudung
    {
        DAL_thoigiansudung dao = new DAL_thoigiansudung();
        public List<THOIGIANSUDUNG> GetAll()
        {
            return dao.GetAll();
        }
        public List<THOIGIANSUDUNG> GebyIDSIM(int SIM)
        {
            return dao.GebyIDSIM(SIM);
        }
        public List<THOIGIANSUDUNG> Get_by_hoadon(HOADON a)
        {
            return dao.Get_by_hoadon(a);
        }
    }
}