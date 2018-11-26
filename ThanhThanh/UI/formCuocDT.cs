using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ThanhThanh.DAL;


namespace ThanhThanh.UI
{
    public partial class formCuocDT : UserControl
    {
        public formCuocDT()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CUOCTHUEBAO cUOCTHUEBAO = new CUOCTHUEBAO();
            cUOCTHUEBAO.IDcuoc = txtmacuoc.EditValue.ToString();

            if (cUOCTHUEBAO.Exits_CUOCTHUEBAO_byMa(cUOCTHUEBAO.IDcuoc))
            {
                MessageBox.Show("Mã cước thuê bao đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                cUOCTHUEBAO.Tencuoc = txtloaicuoc.EditValue.ToString();
                cUOCTHUEBAO.TGBD = TimeSpan.Parse( txtTGBD.EditValue.ToString());
                cUOCTHUEBAO.TGKT = TimeSpan.Parse(txtTGKT.EditValue.ToString());
                cUOCTHUEBAO.Gia = double.Parse(txtgia.EditValue.ToString());
                cUOCTHUEBAO.Ngayapdung = DateTime.Parse(txtngayapdung.EditValue.ToString());
                try
                {
                    cUOCTHUEBAO.insert_cuocthuebao(cUOCTHUEBAO);
                    MessageBox.Show("Thêm cước thuê bao thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Thêm cước thuê bao không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            Load_data();
        }

        private void gvCuocThuebao_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<CUOCTHUEBAO> cUOCTHUEBAOs = ((List<CUOCTHUEBAO>)gvCuocThuebao.DataSource);
            CUOCTHUEBAO cUOCTHUEBAO = cUOCTHUEBAOs[gvCuocThuebao.FocusedRowHandle];
            txtmacuoc.Text = cUOCTHUEBAO.IDcuoc;
            txtloaicuoc.Text = cUOCTHUEBAO.Tencuoc;
            txtTGBD.EditValue = cUOCTHUEBAO.TGBD.ToString();
            txtTGKT.EditValue = cUOCTHUEBAO.TGKT.ToString();
            txtgia.Text = cUOCTHUEBAO.Gia.ToString();
            txtngayapdung.Text = cUOCTHUEBAO.Ngayapdung.ToString();
        }

        private void formCuocDT_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        public void Load_data()
        {

            CUOCTHUEBAO cUOCTHUEBAO = new CUOCTHUEBAO();
            gcCuocthuebao.DataSource = cUOCTHUEBAO.GetAll();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            CUOCTHUEBAO cUOCTHUEBAO = new CUOCTHUEBAO();
            cUOCTHUEBAO.IDcuoc = txtmacuoc.EditValue.ToString();

            if (!cUOCTHUEBAO.Exits_CUOCTHUEBAO_byMa(cUOCTHUEBAO.IDcuoc))
            {
                MessageBox.Show("Mã cước thuê bao Không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                cUOCTHUEBAO.Tencuoc = txtloaicuoc.EditValue.ToString();
                cUOCTHUEBAO.TGBD = TimeSpan.Parse(txtTGBD.EditValue.ToString());
                cUOCTHUEBAO.TGKT = TimeSpan.Parse(txtTGKT.EditValue.ToString());
                cUOCTHUEBAO.Gia = double.Parse(txtgia.EditValue.ToString());
                cUOCTHUEBAO.Ngayapdung = DateTime.Parse(txtngayapdung.EditValue.ToString());
                try
                {
                    cUOCTHUEBAO.update_cuocthuebao(cUOCTHUEBAO);
                    MessageBox.Show("Chỉnh sửa cước thuê bao thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Chỉnh sửa cước thuê không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Load_data();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn xóa cước điện thoại có mã: " + txtmacuoc.EditValue.ToString(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                try
                {
                    CUOCTHUEBAO cUOCTHUEBAO = new CUOCTHUEBAO();
                    cUOCTHUEBAO.IDcuoc = txtmacuoc.EditValue.ToString();
                   cUOCTHUEBAO.delete_cuocthuebao(cUOCTHUEBAO);
                    MessageBox.Show("Xóa cước thuê bao có mã: " + cUOCTHUEBAO.IDcuoc, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_data();
                }
                catch
                {
                    MessageBox.Show("Xóa khách hàng không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
    }
}
