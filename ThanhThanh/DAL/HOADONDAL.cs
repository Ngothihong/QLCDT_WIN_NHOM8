using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;

namespace ThanhThanh.DAL
{
   public class HOADONDAL
    {
        public List<HOADON> GetAll()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.HOADONs.ToList();
        }
        //public IEnumerable<string> GetAllIDSIM()
        //{
        //    QLCDTDataContext db = new QLCDTDataContext();
        //    var listSIM = from a in db.KHACHHANGs select a.IDSim;
        //    return listSIM;
        //}

        public HOADON GetByMa(String ma)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.HOADONs.Where(a => a.IDHD == ma).SingleOrDefault();
        }
        public bool Exits_KH_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public float TinhSophutbanngay ( HOADON a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var soput = ( from thsd in db.THOIGIANSUDUNGs 
                          where ( thsd.IDSim == a.IDsim )  && ( thsd.TGBD >= a.TGBD ) && (thsd.TGBD <= a.TGKT)
                          select thsd.SophutBN );
            if (soput.Count() == 0)
                return 0;
            else
                return (float)soput.Sum();
        }
        public float TinhSophutbandem(HOADON a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var soput = (from thsd in db.THOIGIANSUDUNGs
                         where (thsd.IDSim == a.IDsim) && (thsd.TGBD >= a.TGBD) && (thsd.TGBD <= a.TGKT)
                         select thsd.SophutBD);
            if(soput.Count() == 0)
                return 0;
            else
                return (float)soput.Sum();
        }
        public float Tinhtonggiatien (HOADON a)
        {
            return (float)(a.SophutBN * 200 + a.SophutBD * 150);
        }
        //public KHACHHANG GetBySIM(String ma)
        //{
        //    QLCDTDataContext db = new QLCDTDataContext();
        //    return db.KHACHHANGs.Where(a => a.IDSim == ma).SingleOrDefault();
        //}
        //public bool Exits_KH_bySIM(string ma)
        //{
        //    if (GetBySIM(ma) == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        //public string Ma_of_Sim(string ma)
        //{
        //    QLCDTDataContext db = new QLCDTDataContext();
        //   KHACHHANG x = db.KHACHHANGs.Where(a => a.IDSim == ma).SingleOrDefault();
        //    return x.IDKHACHHANG;
        //}

        //public IEnumerable<String> getTenDaily()
        //{
        //    QLVESODataContext db = new QLVESODataContext();
        //    return db.DaiLies.AsEnumerable().Select(s => s.MaDaiLy);

        //}
        public void insert_HOADON(HOADON a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            db.HOADONs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_Hoadon(HOADON a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            HOADON b = db.HOADONs.Where(x => x.IDHD == a.IDHD).Single();
            b.IDsim = a.IDsim;
            b.TGBD = a.TGBD;
            b.TGKT = a.TGKT;
            b.SophutBN = a.SophutBN;
            b.SophutBD = a.SophutBD;
            b.TongSoTien = a.TongSoTien;
            b.Trangthai = a.Trangthai;
            db.SubmitChanges();
        }
        public void delete_HOADON(HOADON b)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            HOADON a = db.HOADONs.Where(x => x.IDHD == b.IDHD).Single();
            db.HOADONs.DeleteOnSubmit(a);
            db.SubmitChanges();

        }

        public bool Kietrangayhoadon( HOADON a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var ds = db.HOADONs.Where(x => x.IDsim == a.IDsim).ToList();
            foreach( var item in ds)
            {
                if ((a.TGBD >= item.TGBD && a.TGBD <= item.TGKT) || (a.TGKT >= item.TGBD && a.TGKT <= item.TGKT))
                    return false;
            }
            
            return true;
        }

    }
}
