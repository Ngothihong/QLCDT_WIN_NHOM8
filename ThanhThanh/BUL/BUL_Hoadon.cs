using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhThanh.DAL;
using EF;

namespace ThanhThanh.BUL
{
    public class BUL_Hoadon
    {
        HOADONDAL dao = new HOADONDAL();
        public List<HOADON> GetAll()
        {
            return dao.GetAll();
        }
        public HOADON GetByMa(String ma)
        {
            return dao.GetByMa(ma);
        }
        public bool Exits_KH_byMa(string ma)
        {
            return dao.Exits_KH_byMa(ma);
        }
        public float TinhSophutbanngay(HOADON a)
        {
            return dao.TinhSophutbanngay(a);
        }
        public float TinhSophutbandem(HOADON a)
        {
            return dao.TinhSophutbandem(a);
        }
        public float Tinhtonggiatien(HOADON a)
        {
            return dao.Tinhtonggiatien(a);
        }
        public bool Kietrangayhoadon(HOADON a)
        {
            return dao.Kietrangayhoadon(a);
        }
        public void insert_HOADON(HOADON a)
        {
            dao.insert_HOADON(a);
        }
        public void update_Hoadon(HOADON a)
        {
            dao.update_Hoadon(a);
        }
        public void delete_HOADON(HOADON b)
        {
            dao.delete_HOADON(b);
        }
    } 
}
