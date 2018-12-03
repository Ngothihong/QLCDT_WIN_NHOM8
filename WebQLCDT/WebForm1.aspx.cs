using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThanhThanh.DAL;

namespace WebQLCDT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
            gvChiTietCuocGoi.DataSource =tHOIGIANSUDUNG.GetAll();
            gvChiTietCuocGoi.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            string Sim = txtSim.Text;
            string mahoadon = txtmahoadon.Text;
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
            if (Sim != "") // sim ko rong
            {
                var thongtinsim1 = tHONGTINSIM.GetbySDT(Sim);
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
                        List<THOIGIANSUDUNG> list = tHOIGIANSUDUNG.GebyIDSIM(Sim);
                        // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
                        gvChiTietCuocGoi.DataSource = list;
                        gvChiTietCuocGoi.DataBind();
                    }
                    else // mahoadon ko rong
                    {
                        // HOADON hoadon = qLTinhCuocDT.HOADONs.Where(x => x.IDHD == mahoadon).SingleOrDefault();
                        HOADON hOADON = new HOADON();
                        hOADON = hOADON.GetByMa(mahoadon);

                        if (hOADON != null) // ton tai hoa don
                        {
                            //var  list = (from x in qLTinhCuocDT.THOIGIANSUDUNGs
                            //                   where x.IDSim == hOADON.IDsim && x.TGBD >= hOADON.TGBD && x.TGBD <= hOADON.TGKT
                            //                   select x).ToList();
                            var list = tHOIGIANSUDUNG.Get_by_hoadon(hOADON);
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
                    hOADON = hOADON.GetByMa(mahoadon);

                    if (hOADON != null) // ton tai hoa don
                    {
                        //var  list = (from x in qLTinhCuocDT.THOIGIANSUDUNGs
                        //                   where x.IDSim == hOADON.IDsim && x.TGBD >= hOADON.TGBD && x.TGBD <= hOADON.TGKT
                        //                   select x).ToList();
                        var list = tHOIGIANSUDUNG.Get_by_hoadon(hOADON);
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

        //protected void btnTim_Click(object sender, EventArgs e)
        //{
        //    string Sim = txtSim.Text;
        //    string mahoadon = txtmahoadon.Text;
        //    THONGTINSIM tHONGTINSIM = new THONGTINSIM();
        //    THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
        //    if (Sim != "") // sim ko rong
        //    {
        //        var thongtinsim1 = tHONGTINSIM.GetbySDT(Sim);
        //        //var thongtinsim1 = from x in qLTinhCuocDT.THONGTINSIMs
        //        //                   where x.Sdt == Sim
        //        //                   orderby x.IDSim descending
        //        //                   select x;

        //        if (thongtinsim1.Count() == 0) // sim ko ton tai
        //        {
        //            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Số điện thoại không tồn tại');</script>");
        //        }
        //        else // sim ton tai
        //        {
        //            foreach (var item in thongtinsim1)
        //            {
        //                tHONGTINSIM = item;
        //                break;
        //            }

        //            if (mahoadon == "") // mahoadon rong
        //            {
        //                List<THOIGIANSUDUNG> list = tHOIGIANSUDUNG.GebyIDSIM(Sim);
        //                // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
        //                gvChiTietCuocGoi.DataSource = list;
        //                gvChiTietCuocGoi.DataBind();
        //            }
        //            else // mahoadon ko rong
        //            {
        //                // HOADON hoadon = qLTinhCuocDT.HOADONs.Where(x => x.IDHD == mahoadon).SingleOrDefault();
        //                HOADON hOADON = new HOADON();
        //                hOADON = hOADON.GetByMa(mahoadon);

        //                if (hOADON != null) // ton tai hoa don
        //                {
        //                    //var  list = (from x in qLTinhCuocDT.THOIGIANSUDUNGs
        //                    //                   where x.IDSim == hOADON.IDsim && x.TGBD >= hOADON.TGBD && x.TGBD <= hOADON.TGKT
        //                    //                   select x).ToList();
        //                    var list = tHOIGIANSUDUNG.Get_by_hoadon(hOADON);
        //                    // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
        //                    gvChiTietCuocGoi.DataSource = list;
        //                    gvChiTietCuocGoi.DataBind();
        //                }
        //                else // khong ton tai hoa don
        //                {
        //                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Mã hóa đơn không tồn tại');</script>");
        //                }

        //            }

        //        }


        //    }
        //    else
        //    {
        //        if (mahoadon == "") // mahoadon rong
        //        {
        //            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Bạn chưa nhập điều kiện tìm kiếm ');</script>");
        //        }
        //        else // mahoadon ko rong
        //        {
        //            // HOADON hoadon = qLTinhCuocDT.HOADONs.Where(x => x.IDHD == mahoadon).SingleOrDefault();
        //            HOADON hOADON = new HOADON();
        //            hOADON = hOADON.GetByMa(mahoadon);

        //            if (hOADON != null) // ton tai hoa don
        //            {
        //                //var  list = (from x in qLTinhCuocDT.THOIGIANSUDUNGs
        //                //                   where x.IDSim == hOADON.IDsim && x.TGBD >= hOADON.TGBD && x.TGBD <= hOADON.TGKT
        //                //                   select x).ToList();
        //                var list = tHOIGIANSUDUNG.Get_by_hoadon(hOADON);
        //                // List<THOIGIANSUDUNG> list = qLTinhCuocDT.THOIGIANSUDUNGs.Where(x => x.IDSim == tHONGTINSIM.IDSim).ToList();
        //                gvChiTietCuocGoi.DataSource = list;
        //                gvChiTietCuocGoi.DataBind();
        //            }
        //            else // khong ton tai hoa don
        //            {
        //                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Mã hóa đơn không tồn tại');</script>");
        //            }

        //        }

        //    }



        //}
    }
}