using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;

namespace ThanhThanh.DAL
{
    public class CUOCTHUEBAODAL
    {
        public List<CUOCTHUEBAO > GetAll()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.CUOCTHUEBAOs.ToList();
        }
        public CUOCTHUEBAO GetByMa(String ma)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.CUOCTHUEBAOs.Where(a => a.IDcuoc== ma).SingleOrDefault();
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
            QLCDTDataContext db = new QLCDTDataContext();
            db.CUOCTHUEBAOs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public void update_cuocthuebao(CUOCTHUEBAO a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            CUOCTHUEBAO b = db.CUOCTHUEBAOs.Where(x => x.IDcuoc == a.IDcuoc).Single();
            b.Tencuoc = a.Tencuoc;
            b.TGBD = a.TGBD;
            b.TGKT = a.TGKT;
            b.Gia = a.Gia;
            b.Ngayapdung = a.Ngayapdung;
            db.SubmitChanges();
        }
        public void delete_cuocthuebao(CUOCTHUEBAO b)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            CUOCTHUEBAO a = db.CUOCTHUEBAOs.Where(x => x.IDcuoc == b.IDcuoc).Single();
            db.CUOCTHUEBAOs.DeleteOnSubmit(a);
            db.SubmitChanges();

        }
        public float GCBN_apdung( string tencuoc, DateTime a)
        {
            return 0;
        }
        public float GCBD_apdung ( string tencuoc, DateTime a)
        {
            return 0;
        }
    }
   
}
