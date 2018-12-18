using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EF;
using WebQLCDT.BUL;

namespace WebQLCDT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
            BUL_Thoigiansudung bUL_Thoigiansudung = new BUL_Thoigiansudung();
            gvChiTietCuocGoi.DataSource = bUL_Thoigiansudung.GetAll();
            gvChiTietCuocGoi.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            string Sim = txtSim.Text;
            string mahoadon = txtmahoadon.Text;
             THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            BUL_Thongtinsim bUL_Thongtinsim = new BUL_Thongtinsim();
            BUL_Thoigiansudung bUL_Thoigiansudung = new BUL_Thoigiansudung();
            BUL_Hoadon bUL_Hoadon = new BUL_Hoadon();
            //  THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
            if (Sim != "") // sim ko rong
            {
                var thongtinsim1 = bUL_Thongtinsim.GetbySDT(Sim);
                //var thongtinsim1 = from x in qLTinhCuocDT.THONGTINSIMs
                //                   where x.Sdt == Sim
                //                   orderby x.IDSim descending
                //                   select x;

                if (thongtinsim1.Count() == 0) // sim ko ton tai
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Số điện thoại không tồn tại');</script>");
                }
                else // sim ton tai
                {
                    foreach (var item in thongtinsim1)
                    {
                        tHONGTINSIM = item;
                        break;
                    }

                    if (mahoadon == "") // mahoadon rong
                    {
                        List<THOIGIANSUDUNG> list = bUL_Thoigiansudung.GebyIDSIM(tHONGTINSIM.IDSim);
                        // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
                        gvChiTietCuocGoi.DataSource = list;
                        gvChiTietCuocGoi.DataBind();
                    }
                    else // mahoadon ko rong
                    {
                        // HOADON hoadon = qLTinhCuocDT.HOADONs.Where(x => x.IDHD == mahoadon).SingleOrDefault();
                         HOADON hOADON = new HOADON();
                        hOADON = bUL_Hoadon.GetByMa(mahoadon);

                        if (hOADON != null) // ton tai hoa don
                        {
                           
                            var list = bUL_Thoigiansudung.Get_by_hoadon(hOADON);
                            // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
                            gvChiTietCuocGoi.DataSource = list;
                            gvChiTietCuocGoi.DataBind();
                        }
                        else // khong ton tai hoa don
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Mã hóa đơn không tồn tại');</script>");
                        }

                    }

                }


            }
            else
            {
                if (mahoadon == "") // mahoadon rong
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Bạn chưa nhập điều kiện tìm kiếm ');</script>");
                }
                else // mahoadon ko rong
                {
                    // HOADON hoadon = qLTinhCuocDT.HOADONs.Where(x => x.IDHD == mahoadon).SingleOrDefault();
                    HOADON hOADON = new HOADON();
                  
                    hOADON = bUL_Hoadon.GetByMa(mahoadon);

                    if (hOADON != null) // ton tai hoa don
                    {
                        //var  list = (from x in qLTinhCuocDT.THOIGIANSUDUNGs
                        //                   where x.IDSim == hOADON.IDsim && x.TGBD >= hOADON.TGBD && x.TGBD <= hOADON.TGKT
                        //                   select x).ToList();
                        var list = bUL_Thoigiansudung.Get_by_hoadon(hOADON);
                        // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
                        gvChiTietCuocGoi.DataSource = list;
                        gvChiTietCuocGoi.DataBind();
                    }
                    else // khong ton tai hoa don
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Mã hóa đơn không tồn tại');</script>");
                    }

                }

            }
        }

        
    }
}