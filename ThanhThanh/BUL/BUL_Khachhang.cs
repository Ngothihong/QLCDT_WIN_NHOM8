using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhThanh.DAL;
using EF;

namespace ThanhThanh.BUL
{
   public class BUL_Khachhang
    {
        KHACHHANGDAL dao = new KHACHHANGDAL();
        public List<KHACHHANG> GetAll()
        {
            return dao.GetAll();
        }
        //public IEnumerable<string> GetAllIDSIM()
        //{
        //    QLCDTDataContext db = new QLCDTDataContext();
        //    var listSIM = from a in db.KHACHHANGs select a.IDSim;
        //    return listSIM;
        //}

        public KHACHHANG GetByMa(String ma)
        {
            return dao.GetByMa(ma);
        }
        public bool Exits_KH_byMa(string ma)
        {
            if (GetByMa(ma) == null)
            {
                return false;
            }
            return true;
        }
        public List<KHACHHANG> Get_KHACHHANG_BySIM(int ma)
        {
            return dao.Get_KHACHHANG_BySIM(ma);
        }
        
        public void insert_Khachhang(KHACHHANG a)
        {
            dao.insert_Khachhang(a);
        }
        public void update_KhachHang(KHACHHANG a)
        {
            dao.update_KhachHang(a);
        }
        public void delete_KHACHHANG(KHACHHANG b)
        {
            dao.delete_KHACHHANG(b);

        }
    }
}
