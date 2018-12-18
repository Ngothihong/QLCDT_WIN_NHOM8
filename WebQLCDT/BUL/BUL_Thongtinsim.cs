using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebQLCDT.DAL;
using EF;

namespace WebQLCDT.BUL
{
    public class BUL_Thongtinsim
    {
        DAL_Thongtinsim dao = new DAL_Thongtinsim();
        public List<THONGTINSIM> GetbySDT(string Sim)
        {
            return dao.GetbySDT(Sim);

        }
    }
}