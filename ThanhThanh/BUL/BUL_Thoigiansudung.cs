using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using ThanhThanh.DAL;

namespace ThanhThanh.BUL
{
   public class BUL_Thoigiansudung
    {
        THOIGIANSUDUNGDAL dao = new THOIGIANSUDUNGDAL();
        public List<THOIGIANSUDUNG> GetAll()
        {
            return dao.GetAll();
        }
        public List<THOIGIANSUDUNG> Get_by_hoadon(HOADON a)
        {
          return  dao.Get_by_hoadon(a);
        }
        public float tinhsophutbanngay1(DateTime BD, DateTime KT)
        {
            return dao.tinhsophutbanngay1(BD, KT);
        }
        public float tinhsophutbandem1(DateTime BD, DateTime KT)
        {
            return dao.tinhsophutbandem1(BD, KT);
        }
        public float tinhgia(float BN, float BD)
        {
            return dao.tinhgia(BN, BD);
        }
        public void insert_Thoigiansudung(THOIGIANSUDUNG a)
        {
            dao.insert_Thoigiansudung(a);
        }
    }
}
