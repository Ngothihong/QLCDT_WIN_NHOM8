using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhThanh.DAL;
using EF;

namespace ThanhThanh.BUL
{
    class BUL_Cuocthuebao
    {
        CUOCTHUEBAODAL dao = new CUOCTHUEBAODAL();
        public List<CUOCTHUEBAO> GetAll()
        {
            return dao.GetAll();
        }
        public CUOCTHUEBAO GetByMa(String ma)
        {
            return dao.GetByMa(ma);
        }
        public bool Exits_CUOCTHUEBAO_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public void insert_cuocthuebao(CUOCTHUEBAO a)
        {
            dao.insert_cuocthuebao(a);
        }
        public void update_cuocthuebao(CUOCTHUEBAO a)
        {
            dao.update_cuocthuebao(a);
        }
        public void delete_cuocthuebao(CUOCTHUEBAO b)
        {
            dao.delete_cuocthuebao(b);

        }
        public float GCBN_apdung(string tencuoc, DateTime a)
        {
          return  dao.GCBD_apdung(tencuoc, a);
        }
        public float GCBD_apdung(string tencuoc, DateTime a)
        {
            return dao.GCBD_apdung(tencuoc,a);
        }
    }
}
