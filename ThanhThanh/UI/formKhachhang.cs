using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhThanh.DAL;
using System.Drawing.Printing;

namespace ThanhThanh.UI
{
    public partial class formKhachhang : UserControl
    {

        public formKhachhang()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dcKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void formKhachhang_Load(object sender, EventArgs e)
        {
            Load_GC_KHACHHANG();
            Load_ThongtinSim();
        }
        public void Load_GC_KHACHHANG()
        {
            KHACHHANG kHACHHANG = new KHACHHANG();
            gcKhachHang.DataSource = kHACHHANG.GetAll();
        }
        public void Load_ThongtinSim()
        {
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            gcThongtinSim.DataSource = tHONGTINSIM.GetAll();
        }

        private void gvKhachhang_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<KHACHHANG> kHACHHANGs = ((List<KHACHHANG>)gvKhachhang.DataSource);
            KHACHHANG khachhang = kHACHHANGs[gvKhachhang.FocusedRowHandle];
            txtmakhachhang.Text = khachhang.IDKHACHHANG;
            txttenkhachhang.Text = khachhang.Tenkhachhang;
            txtcmnd.Text = khachhang.CMND;
            txtchucvu.Text = khachhang.Chucvu;
            txtnghenghiep.Text = khachhang.Nghenghiep;
            txtdiachi.Text = khachhang.Diachi;
            txtemail.Text = khachhang.Email;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KHACHHANG kHACHHANG = new KHACHHANG();
            kHACHHANG.IDKHACHHANG = txtmakhachhang.EditValue.ToString();

            if (kHACHHANG.Exits_KH_byMa(kHACHHANG.IDKHACHHANG))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                kHACHHANG.Tenkhachhang = txttenkhachhang.EditValue.ToString();
                kHACHHANG.Chucvu = txtchucvu.EditValue.ToString();
                kHACHHANG.Nghenghiep = txtnghenghiep.EditValue.ToString();
                kHACHHANG.Email = txtemail.EditValue.ToString();
                kHACHHANG.Diachi = txtdiachi.EditValue.ToString();
                kHACHHANG.CMND = txtcmnd.EditValue.ToString();
                try
                {
                    kHACHHANG.insert_Khachhang(kHACHHANG);
                    MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm khách hàng không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Load_GC_KHACHHANG();

            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KHACHHANG kHACHHANG = new KHACHHANG();
            kHACHHANG.IDKHACHHANG = txtmakhachhang.EditValue.ToString();

            if (!kHACHHANG.Exits_KH_byMa(kHACHHANG.IDKHACHHANG))
            {
                MessageBox.Show("Mã khách hàng Không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                kHACHHANG.Tenkhachhang = txttenkhachhang.EditValue.ToString();
                kHACHHANG.Chucvu = txtchucvu.EditValue.ToString();
                kHACHHANG.Nghenghiep = txtnghenghiep.EditValue.ToString();
                kHACHHANG.Email = txtemail.EditValue.ToString();
                kHACHHANG.Diachi = txtdiachi.EditValue.ToString();
                kHACHHANG.CMND = txtcmnd.EditValue.ToString();
                try
                {
                    kHACHHANG.update_KhachHang(kHACHHANG);
                    MessageBox.Show("Chỉnh sửa thông tin khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Chỉnh sửa thông tin không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Load_GC_KHACHHANG();


            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn xóa Khách hàng có mã: " + txtmakhachhang.EditValue.ToString(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                try
                {
                    KHACHHANG kHACHHANG = new KHACHHANG();
                    kHACHHANG.IDKHACHHANG = txtmakhachhang.EditValue.ToString();
                    kHACHHANG.delete_KHACHHANG(kHACHHANG);
                    MessageBox.Show("Xóa khách hàng có mã: " + kHACHHANG.IDKHACHHANG, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_GC_KHACHHANG();
                }
                catch
                {
                    MessageBox.Show("Xóa khách hàng không thành công, khách hàng đã đăng ký sim", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            tHONGTINSIM.IDSim = txtmasimdk.EditValue.ToString();

            if (tHONGTINSIM.Exits_KH_byMa(tHONGTINSIM.IDSim))
            {
                MessageBox.Show("Mã Sim đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                tHONGTINSIM.IDKHACHHANG = txtmakhachhangdk.EditValue.ToString();
                tHONGTINSIM.Sdt = txtSDT.EditValue.ToString();
                tHONGTINSIM.NgayDK = DateTime.Parse(txtngadk.EditValue.ToString());
                tHONGTINSIM.CuocDK = float.Parse(txtcuocdk.EditValue.ToString());
                try
                {
                    tHONGTINSIM.insert_Thongtinsim(tHONGTINSIM);
                    MessageBox.Show("Thêm 1 đăng ký sim thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm 1 đăng ký sim không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Load_GC_KHACHHANG();

            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            tHONGTINSIM.IDSim = txtmasimdk.EditValue.ToString();

            if (!tHONGTINSIM.Exits_KH_byMa(tHONGTINSIM.IDSim))
            {
                MessageBox.Show("Mã Sim không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                tHONGTINSIM.IDKHACHHANG = txtmakhachhangdk.EditValue.ToString();
                tHONGTINSIM.Sdt = txtSDT.EditValue.ToString();
                tHONGTINSIM.NgayDK = DateTime.Parse(txtngadk.EditValue.ToString());
                tHONGTINSIM.CuocDK = float.Parse(txtcuocdk.EditValue.ToString());
                try
                {
                    tHONGTINSIM.update_Thongtinsim(tHONGTINSIM);
                    MessageBox.Show("Chỉnh sửa thông tin ĐK sim thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Chỉnh sửa thông tin không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Load_GC_KHACHHANG();


            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn xóa ĐK sim có mã: " + txtmakhachhang.EditValue.ToString(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                try
                {
                     THONGTINSIM tHONGTINSIM = new THONGTINSIM();
                    tHONGTINSIM.IDSim = txtmasimdk.EditValue.ToString();
                    tHONGTINSIM.delete_thongtinSim(tHONGTINSIM);
                    MessageBox.Show("Xóa ĐK sim có mã: " + tHONGTINSIM.IDSim, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_GC_KHACHHANG();
                }
                catch
                {
                    MessageBox.Show("Xóa ĐK simkhông thành công, mã sim đã tham gia sử dụng các cước gọi", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void gvThongtinSim_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            List<THONGTINSIM> tHONGTINSIMs = ((List<THONGTINSIM>)gvThongtinSim.DataSource);
            THONGTINSIM tHONGTINSIM = tHONGTINSIMs[gvThongtinSim.FocusedRowHandle];
            txtmasimdk.Text = tHONGTINSIM.IDSim;
            txtmakhachhangdk.Text = tHONGTINSIM.IDKHACHHANG;
            txtSDT.Text = tHONGTINSIM.Sdt;
            txtngadk.Text = tHONGTINSIM.NgayDK.ToString();
            txtcuocdk.Text = tHONGTINSIM.CuocDK.ToString();

        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            Load_ThongtinSim();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            if( txtmakhachhang.EditValue == null)
            {
                MessageBox.Show(" Bạn chưa chọn mã khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tHONGTINSIM.IDKHACHHANG = txtmakhachhang.EditValue.ToString();
                gcThongtinSim.DataSource = tHONGTINSIM.GetThongtinSim_bymakhachhang(tHONGTINSIM.IDKHACHHANG);
            }
            
        }
        Bitmap bmp;
        private void btxuathđK_Click(object sender, EventArgs e)
        {
            if (txtmasimdk.EditValue == null)
            {
                MessageBox.Show("Bạn chưa sim đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                THONGTINSIM tHONGTINSIM = new THONGTINSIM();
                //KHACHHANG kHACHHANG = new KHACHHANG();
                //HOADON hOADON = new HOADON();
                tHONGTINSIM.IDSim = txtmasimdk.EditValue.ToString();
               // hOADON.IDHD = txtmahoadon.EditValue.ToString();

                if (!tHONGTINSIM.Exits_KH_byMa(tHONGTINSIM.IDSim))
                {
                    MessageBox.Show("Không tồn tại đăng ký sim có mã:" + tHONGTINSIM.IDSim.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        PrintDialog _PrintDialog = new PrintDialog();
                        PrintDocument _PrintDocument = new PrintDocument();

                        _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                        _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                                                                                                                       //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                        DialogResult result = _PrintDialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            _PrintDocument.Print();
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //tao doi tuong
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            //KHACHHANG kHACHHANG = new KHACHHANG();
            //HOADON hOADON = new HOADON();
            tHONGTINSIM.IDSim = txtmasimdk.EditValue.ToString();

            tHONGTINSIM = tHONGTINSIM.GetByMa(tHONGTINSIM.IDSim);
            KHACHHANG kHACHHANG = new KHACHHANG();
            kHACHHANG = kHACHHANG.GetByMa(tHONGTINSIM.IDKHACHHANG);
            // ve hoa don
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("HÓA ĐƠN ĐĂNG KÝ THẺ SIM", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            // string top = "Tên Sản Phẩm".PadRight(24) + "Thành Tiền";
            // graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);

            graphic.DrawString("Mã đăng ký", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tHONGTINSIM.IDSim, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent


            graphic.DrawString("THÔNG TIN KHÁCH HÀNG", new Font("Courier New", 15), new SolidBrush(Color.Black), startX, startY + offset);
            //int index = 0;
            //foreach (string item in lsbTenSanPham.Items)
            //{
            //    graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
            //    graphic.DrawString(lsbThanhTien.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
            //    offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            //}

            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("Tên khách hàng ", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(kHACHHANG.Tenkhachhang, new Font("Courier New", 12), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("CMND", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(kHACHHANG.CMND, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Nghề nghiệp ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(kHACHHANG.Nghenghiep, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Chức vụ ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(kHACHHANG.Chucvu, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Địa chỉ ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(kHACHHANG.Diachi, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Email ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(kHACHHANG.Email, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            // thong tin sim 

            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent


            graphic.DrawString("THÔNG TIN HÓA ĐƠN ĐĂNG KÝ", new Font("Courier New", 15), new SolidBrush(Color.Black), startX, startY + offset);
            //int index = 0;
            //foreach (string item in lsbTenSanPham.Items)
            //{
            //    graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
            //    graphic.DrawString(lsbThanhTien.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
            //    offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            //}

            //offset = offset + 20; //make some room so that the total stands out.

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Số điện thoại", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tHONGTINSIM.Sdt, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Ngày đăng ký:", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tHONGTINSIM.NgayDK.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Cước đăng ký ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(tHONGTINSIM.CuocDK.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

           
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("XIN QUÝ KHÁCH VUI LÒNG THANH TOÁN TRƯỚC 15 NGÀY KỂ TỪ NGÀY XUẤT HÓA ĐƠN( " + DateTime.Now.ToString() + ")", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" CẢM ƠN QUÝ KHÁCH ĐÃ SỬ DỤNG DỊCH VỤ CỦA CHÚNG TÔI,", font, new SolidBrush(Color.Black), startX, startY + offset);


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
