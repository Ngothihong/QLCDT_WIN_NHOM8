using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhThanh.DAL
{
   partial class THONGTINSIM
    {
        public List<THONGTINSIM> GetAll()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.THONGTINSIMs.ToList();
        }
        public IEnumerable<string> GetAllIDSIM()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var listSIM = from a in db.THONGTINSIMs select a.IDSim;
            return listSIM;
        }
  
        public THONGTINSIM GetByMa(String ma)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.THONGTINSIMs.Where(a => a.IDSim== ma).SingleOrDefault();
        }
        public bool Exits_KH_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public List<THONGTINSIM> GetThongtinSim_bymakhachhang (String ma)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.THONGTINSIMs.Where(a => a.IDKHACHHANG == ma).ToList();
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
        public void insert_Thongtinsim( THONGTINSIM a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            db.THONGTINSIMs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_Thongtinsim(THONGTINSIM a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            THONGTINSIM b = db.THONGTINSIMs.Where(x => x.IDSim == a.IDSim).Single();
            b.IDKHACHHANG = a.IDKHACHHANG;
            b.Sdt = a.Sdt;
            b.NgayDK = a.NgayDK;
            b.CuocDK = a.CuocDK;
            db.SubmitChanges();
        }
        public void delete_thongtinSim(THONGTINSIM b)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            THONGTINSIM a = db.THONGTINSIMs.Where(x => x.IDSim == b.IDSim).Single();
            db.THONGTINSIMs.DeleteOnSubmit(a);
            db.SubmitChanges();

        }
        //public IEnumerable<CongNo> GetCongNosbyMaDaily(String ma)
        //{
        //    QLVESODataContext db = new QLVESODataContext();
        //    return db.CongNos.Where(a => a.MaDaiLy == ma).ToList();
        //}
    }
}
