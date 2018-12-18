using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhThanh.DAL;
using EF;

namespace ThanhThanh.BUL
{
    class BUL_Thongtinsim
    {
        THONGTINSIMDAL dao = new THONGTINSIMDAL();
        public List<THONGTINSIM> GetAll()
        {
            return dao.GetAll();
        }
        public List<THONGTINSIM> GetbySDT(string Sim)
        {
            return dao.GetbySDT(Sim);

        }
        public IEnumerable<int> GetAllIDSIM()
        {
            return dao.GetAllIDSIM();
        }

        public THONGTINSIM GetByMa(int ma)
        {
            return dao.GetByMa(ma);
        }
        public bool Exits_KH_byMa(int ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public List<THONGTINSIM> GetThongtinSim_bymakhachhang(String ma)
        {
            return dao.GetThongtinSim_bymakhachhang(ma);
        }
        ////public bool Exits_KH_bySIM(string ma)
        ////{
        ////    if (GetBySIM(ma) == null)
        ////    {
        ////        return false;
        ////    }
        ////    return true;
        ////}
        ////public string Ma_of_Sim(string ma)
        ////{
        ////    QLCDTDataContext db = new QLCDTDataContext();
        ////   KHACHHANG x = db.KHACHHANGs.Where(a => a.IDSim == ma).SingleOrDefault();
        ////    return x.IDKHACHHANG;
        ////}

        ////public IEnumerable<String> getTenDaily()
        ////{
        ////    QLVESODataContext db = new QLVESODataContext();
        ////    return db.DaiLies.AsEnumerable().Select(s => s.MaDaiLy);

        ////}
        public void insert_Thongtinsim(THONGTINSIM a)
        {
            dao.insert_Thongtinsim(a);
        }
        public void update_Thongtinsim(THONGTINSIM a)
        {
            dao.update_Thongtinsim(a);
        }
        public void delete_thongtinSim(THONGTINSIM b)
        {
            dao.delete_thongtinSim(b);

        }

    }
}
