using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanhThanh.DAL
{
   partial class THOIGIANSUDUNG
    {
        public List<THOIGIANSUDUNG> GetAll()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            return db.THOIGIANSUDUNGs.ToList();
        }
        public List<THOIGIANSUDUNG> Get_by_hoadon( HOADON a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var abc = (from  thsd in db.THOIGIANSUDUNGs
                         where (thsd.IDSim == a.IDsim) && (thsd.TGBD >= a.TGBD) && (thsd.TGBD <= a.TGKT) 
                         select  thsd);

            return abc.ToList();
        }
        public void insert_Thoigiansudung(THOIGIANSUDUNG a)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            db.THOIGIANSUDUNGs.InsertOnSubmit(a);
            db.SubmitChanges();
        }
        public int max_STT()
        {
            QLCDTDataContext db = new QLCDTDataContext();
            var maxValue = db.THOIGIANSUDUNGs.Max(x => x.STT);
            return maxValue;
        }
        public float tinhsophutbanngay1(DateTime BD, DateTime KT)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            CUOCTHUEBAO cUOCTHUEBAO = new CUOCTHUEBAO();
            var abc = (from a in db.CUOCTHUEBAOs
                       where a.Tencuoc == "Banngay" && a.Ngayapdung <= BD.Date
                       orderby a.Ngayapdung descending
                       select a).Take(1);
            foreach (var item in abc)
            {
                cUOCTHUEBAO.TGBD = item.TGBD;
                cUOCTHUEBAO.TGKT = item.TGKT;
                break;
            }
            
            //7-------------23
            if (BD.TimeOfDay >= cUOCTHUEBAO.TGBD && BD.TimeOfDay < cUOCTHUEBAO.TGKT) // neu bat dau trong cuoc ngay 
            {
                if (KT.TimeOfDay >= cUOCTHUEBAO.TGBD && KT.TimeOfDay < cUOCTHUEBAO.TGKT) // kt trong cuoc ngay
                    return (float)((KT.TimeOfDay.TotalSeconds - BD.TimeOfDay.TotalSeconds) / 60);
                // return (float)(((KT.Hour * 3600 + KT.Minute * 60 + KT.Second) - (BD.Hour * 3600 + BD.Minute * 60 + BD.Second)) / 60);
                else // kt truoc cuoc dem
                {
                    return (float)(( cUOCTHUEBAO.TGKT.TotalSeconds - BD.TimeOfDay.TotalSeconds) / 60);
                    // return (float)((cUOCTHUEBAO.TGKT.TotalSeconds  - (BD.Hour * 3600 + BD.Minute * 60 + BD.Second)) / 60);
                }

            }

            else // bat dau trong cuoc dem
            {
                if (KT.TimeOfDay >= cUOCTHUEBAO.TGBD && KT.TimeOfDay < cUOCTHUEBAO.TGKT) // kt trong cuoc ngay
                     // return (float)(((KT.Hour * 3600 + KT.Minute * 60 + KT.Minute) - cUOCTHUEBAO.TGBD.TotalSeconds) / 60);
                    return (float)((KT.TimeOfDay.TotalSeconds - cUOCTHUEBAO.TGBD.TotalSeconds) / 60);
                else // kt trong cuoc dem 
                    return 0;
            }
        }
        public float tinhsophutbandem1(DateTime BD, DateTime KT)
        {
            QLCDTDataContext db = new QLCDTDataContext();
            CUOCTHUEBAO cUOCTHUEBAO = new CUOCTHUEBAO();
            var abc = (from a in db.CUOCTHUEBAOs
                       where a.Tencuoc == "Bandem" && a.Ngayapdung >= BD.Date
                       orderby a.Ngayapdung descending
                       select a).Take(1);
            foreach (var item in abc)
            {
                cUOCTHUEBAO.TGBD = item.TGBD;
                cUOCTHUEBAO.TGKT = item.TGKT;
                break;
            }
            //23-------------7
            if (BD.TimeOfDay <= cUOCTHUEBAO.TGBD && BD.TimeOfDay > cUOCTHUEBAO.TGKT) // bat dau trong cuoc ngay 
            {
                if (KT.TimeOfDay <= cUOCTHUEBAO.TGBD && KT.TimeOfDay > cUOCTHUEBAO.TGKT) // ket thuc trong cuoc ngay
                    return 0;
                else // ket thuc trong cuoc dem
                {
                    if (KT.Hour <= 23 && KT.Hour >= cUOCTHUEBAO.TGKT.Hours)
                        return (float)((KT.TimeOfDay.TotalSeconds - cUOCTHUEBAO.TGBD.TotalSeconds) / 60);
                    else
                        return (float)((24 * 3600 - cUOCTHUEBAO.TGBD.TotalSeconds + KT.TimeOfDay.TotalSeconds) / 60);
                }
            }
            else // bat dau trong cuoc dem 
            {
                if (KT.TimeOfDay <= cUOCTHUEBAO.TGBD && KT.TimeOfDay > cUOCTHUEBAO.TGKT) // ket thuc trong ngay 
                {
                    if (BD.Hour <= 23 && BD.Hour >= cUOCTHUEBAO.TGKT.Hours )
                        return (float)(((24 * 3600 - BD.TimeOfDay.TotalSeconds) + cUOCTHUEBAO.TGKT.TotalSeconds) / 60);
                    else
                        return (float)((cUOCTHUEBAO.TGKT.TotalSeconds - BD.TimeOfDay.TotalSeconds) / 60);
                }

                else // ket thuc trong dem
                {
                    if (BD.Hour >= cUOCTHUEBAO.TGBD.Hours && KT.Hour >= BD.Hour)
                    {
                        return (float)((KT.TimeOfDay.TotalSeconds - BD.TimeOfDay.TotalSeconds)/60);
                    }
                    if (BD.Hour >= cUOCTHUEBAO.TGBD.Hours && KT.Hour < BD.Hour)
                    {
                        return (float)((24*3600 - BD.TimeOfDay.TotalSeconds + KT.TimeOfDay.TotalSeconds)/60);
                    }
                   
                        return (float)((KT.TimeOfDay.TotalSeconds - BD.TimeOfDay.TotalSeconds)/60);
                    
                    
                    //    return (float)(((24 * 3600 - BD.TimeOfDay.TotalSeconds) + cUOCTHUEBAO.TGKT.TotalSeconds) / 60);
                    //else
                    //    return (float)((cUOCTHUEBAO.TGKT.TotalSeconds - BD.TimeOfDay.TotalSeconds) / 60);

                    //if (KT.Hour <= cUOCTHUEBAO.TGKT.Hours)
                    //    return (float)((KT.TimeOfDay.TotalSeconds - BD.TimeOfDay.TotalSeconds) / 60);
                    //else
                    //    return (float)((24 * 3600 - BD.TimeOfDay.TotalSeconds) + KT.TimeOfDay.TotalSeconds);

                }

            }
        }
        public float tinhsophutbanngay(DateTime BD , DateTime KT)
        {

        if (BD.Hour >= 7 && BD.Hour < 23 ) // neu bat dau trong cuoc ngay
            {
                if (KT.Hour >= 7 && KT.Hour < 23) // kt trong cuoc ngay
                    return (float) (((KT.Hour * 3600 + KT.Minute * 60 + KT.Second) - (BD.Hour * 3600 + BD.Minute * 60 + BD.Second)) / 60 ) ;
                else // kt truoc cuoc dem
                {
                    return (float)(( 23*3600 - (BD.Hour * 3600 + BD.Minute * 60 + BD.Second))/60);
                }
            }
        else // bat dau truoc cuoc dem
            {
                if (KT.Hour >= 7 && KT.Hour < 23) // kt trong cuoc ngay
                    return (float)(((KT.Hour * 3600 + KT.Minute * 60 + KT.Minute) - 7*3600 ) / 60);
                else // kt trong cuoc dem 
                    return 0;
            }
        }

        public float tinhsophutbandem(DateTime BD, DateTime KT)
        {
            if (BD.Hour >= 7 && BD.Hour < 23) // bat dau trong cuoc ngay 
            {
                if (KT.Hour >= 7 && KT.Hour < 23) // ket thuc trong cuoc ngay
                    return 0;
                else // ket thuc trong ket dem
                {
                    if (KT.Hour == 23)
                        return (float)((KT.Minute*60 + KT.Second)/60);
                    else       
                        return (float)((3600 + KT.Hour * 3600 + KT.Minute * 60 + KT.Minute) / 60);
                }
            }
            else // bat dau trong dem 
            {
                if (KT.Hour >= 7 && KT.Hour < 23) // ket thuc trong ngay 
                {
                    if (BD.Hour == 23)
                        return (float)((7 * 3600 + (3600 -( BD.Minute * 60 + BD.Second ))) / 60);
                    else
                        return (float)((7 * 3600 - (BD.Hour * 3600 + BD.Minute * 60 + BD.Second)) / 60);
                }
                   
                else
                    return (float)(((KT.Hour * 3600 + KT.Minute * 60 + KT.Minute) - (BD.Hour * 3600 + BD.Minute * 60 + BD.Minute)) / 60); ;
            }
        }
        public float tinhgia (float BN , float BD)
        {
            return (BN * 200 + BD * 150);
        }
    }

}
