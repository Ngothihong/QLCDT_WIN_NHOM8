using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhThanh.DAL
{
   partial class KHACHHANG
    {
        public List<KHACHHANG> GetAll()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.KHACHHANGs.ToList();
        }
        //public IEnumerable<string> GetAllIDSIM()
        //{
        //    QLCDTDataContext db = new QLCDTDataContext();
        //    var listSIM = from a in db.KHACHHANGs select a.IDSim;
        //    return listSIM;
        //}

        public KHACHHANG GetByMa(String ma)
        {
           QLCDTDataContext db = new QLCDTDataContext();
            return db.KHACHHANGs.Where(a => a.IDKHACHHANG == ma).SingleOrDefault();
        }
        public bool Exits_KH_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public List <KHACHHANG> Get_KHACHHANG_BySIM(String ma)
        {
            QLCDTDataContext db = new QLCDTDataContext();
           var model = (from a in db.THONGTINSIMs
                                      join b in db.KHACHHANGs
                                      on a.IDKHACHHANG equals b.IDKHACHHANG
                                      where a.IDSim == ma 
                                      select b ).Take(1);
            return model.ToList();
        }
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
        public void insert_Khachhang(KHACHHANG a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            db.KHACHHANGs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_KhachHang(KHACHHANG a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            KHACHHANG b = db.KHACHHANGs.Where(x => x.IDKHACHHANG == a.IDKHACHHANG).Single();
            b.IDKHACHHANG = a.IDKHACHHANG;
            b.Tenkhachhang = a.Tenkhachhang;
            b.CMND = a.CMND;
            b.Chucvu = a.Chucvu;
            b.Email = a.Email;
            b.Nghenghiep = a.Nghenghiep;
            db.SubmitChanges();
        }
        public void delete_KHACHHANG(KHACHHANG b)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            KHACHHANG a = db.KHACHHANGs.Where(x => x.IDKHACHHANG == b.IDKHACHHANG).Single();
            db.KHACHHANGs.DeleteOnSubmit(a);
            db.SubmitChanges();

        }
        //public IEnumerable<CongNo> GetCongNosbyMaDaily(String ma)
        //{
        //    QLVESODataContext db = new QLVESODataContext();
        //    return db.CongNos.Where(a => a.MaDaiLy == ma).ToList();
        //}
    }
}
