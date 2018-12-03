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
using System.Threading;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace ThanhThanh.UI
{
    public partial class formHoadon : UserControl
    {
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txtmahoadon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btxoa;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit txtngabd;
        private DevExpress.XtraEditors.TextEdit txtsopphutbn;
        private DevExpress.XtraEditors.TextEdit txtspbd;
        private DevExpress.XtraGrid.GridControl gcThoigiansudung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThoigiansudung;
        private GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gcHoadon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoadon;
        private DevExpress.XtraEditors.SimpleButton btthoigiansudung;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSIM;
        private DevExpress.XtraGrid.Columns.GridColumn ColTGBD;
        private DevExpress.XtraGrid.Columns.GridColumn colTGKT;
        private DevExpress.XtraGrid.Columns.GridColumn colSPBN;
        private DevExpress.XtraGrid.Columns.GridColumn ColSPBD;
        private DevExpress.XtraGrid.Columns.GridColumn colGia;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHD;
        private DevExpress.XtraGrid.Columns.GridColumn colHDSIM;
        private DevExpress.XtraGrid.Columns.GridColumn colHDNGBD;
        private DevExpress.XtraGrid.Columns.GridColumn colHDNKT;
        private DevExpress.XtraGrid.Columns.GridColumn colHDSPBN;
        private DevExpress.XtraGrid.Columns.GridColumn colHDSPBD;
        private DevExpress.XtraGrid.Columns.GridColumn colHDGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colHDtrangthai;
        private DevExpress.XtraEditors.DateEdit txtngkt;
        private DevExpress.XtraEditors.ComboBoxEdit cbMasim;
        private DevExpress.XtraEditors.TextEdit txttonggia;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbtrangthai;
        private Button button1;
        private DevExpress.XtraEditors.SimpleButton buthoadon;
        private PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl1;

        public formHoadon()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHoadon));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gcThoigiansudung = new DevExpress.XtraGrid.GridControl();
            this.gvThoigiansudung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTGBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSPBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buthoadon = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gcHoadon = new DevExpress.XtraGrid.GridControl();
            this.gvHoadon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDNGBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDNKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDSPBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDSPBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDtrangthai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btthoigiansudung = new DevExpress.XtraEditors.SimpleButton();
            this.btxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtmahoadon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtngabd = new DevExpress.XtraEditors.DateEdit();
            this.txtsopphutbn = new DevExpress.XtraEditors.TextEdit();
            this.txtspbd = new DevExpress.XtraEditors.TextEdit();
            this.txtngkt = new DevExpress.XtraEditors.DateEdit();
            this.cbMasim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txttonggia = new DevExpress.XtraEditors.TextEdit();
            this.cbtrangthai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThoigiansudung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoigiansudung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoadon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngabd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngabd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsopphutbn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtspbd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngkt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngkt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMasim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttonggia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtrangthai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1365, 582);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.gcThoigiansudung);
            this.groupBox2.Location = new System.Drawing.Point(677, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 562);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian sử dụng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tải lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gcThoigiansudung
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gcThoigiansudung.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcThoigiansudung.Location = new System.Drawing.Point(19, 58);
            this.gcThoigiansudung.MainView = this.gvThoigiansudung;
            this.gcThoigiansudung.Name = "gcThoigiansudung";
            this.gcThoigiansudung.Size = new System.Drawing.Size(637, 498);
            this.gcThoigiansudung.TabIndex = 0;
            this.gcThoigiansudung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThoigiansudung});
            // 
            // gvThoigiansudung
            // 
            this.gvThoigiansudung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colIDSIM,
            this.ColTGBD,
            this.colTGKT,
            this.colSPBN,
            this.ColSPBD,
            this.colGia});
            this.gvThoigiansudung.GridControl = this.gcThoigiansudung;
            this.gvThoigiansudung.Name = "gvThoigiansudung";
            this.gvThoigiansudung.OptionsFind.AlwaysVisible = true;
            // 
            // colSTT
            // 
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            // 
            // colIDSIM
            // 
            this.colIDSIM.Caption = "Mã sim";
            this.colIDSIM.FieldName = "IDSim";
            this.colIDSIM.Name = "colIDSIM";
            this.colIDSIM.Visible = true;
            this.colIDSIM.VisibleIndex = 1;
            // 
            // ColTGBD
            // 
            this.ColTGBD.Caption = "Thời gian bắt đầu";
            this.ColTGBD.DisplayFormat.FormatString = "G";
            this.ColTGBD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColTGBD.FieldName = "TGBD";
            this.ColTGBD.Name = "ColTGBD";
            this.ColTGBD.Visible = true;
            this.ColTGBD.VisibleIndex = 2;
            // 
            // colTGKT
            // 
            this.colTGKT.Caption = "Thời gian kết thúc";
            this.colTGKT.DisplayFormat.FormatString = "G";
            this.colTGKT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTGKT.FieldName = "TGKT";
            this.colTGKT.Name = "colTGKT";
            this.colTGKT.Visible = true;
            this.colTGKT.VisibleIndex = 3;
            // 
            // colSPBN
            // 
            this.colSPBN.Caption = "Số phút ban ngày";
            this.colSPBN.FieldName = "SophutBN";
            this.colSPBN.Name = "colSPBN";
            this.colSPBN.Visible = true;
            this.colSPBN.VisibleIndex = 4;
            // 
            // ColSPBD
            // 
            this.ColSPBD.Caption = "Số phút ban đêm";
            this.ColSPBD.FieldName = "SophutBD";
            this.ColSPBD.Name = "ColSPBD";
            this.ColSPBD.Visible = true;
            this.ColSPBD.VisibleIndex = 5;
            // 
            // colGia
            // 
            this.colGia.Caption = "Giá";
            this.colGia.FieldName = "Gia";
            this.colGia.Name = "colGia";
            this.colGia.Visible = true;
            this.colGia.VisibleIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buthoadon);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btthoigiansudung);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 603);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // buthoadon
            // 
            this.buthoadon.Location = new System.Drawing.Point(565, 118);
            this.buthoadon.Name = "buthoadon";
            this.buthoadon.Size = new System.Drawing.Size(92, 23);
            this.buthoadon.TabIndex = 3;
            this.buthoadon.Text = "Xuất hóa đơn";
            this.buthoadon.Click += new System.EventHandler(this.buthoadon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gcHoadon);
            this.groupBox4.Location = new System.Drawing.Point(7, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(650, 396);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn";
            // 
            // gcHoadon
            // 
            this.gcHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHoadon.Location = new System.Drawing.Point(3, 17);
            this.gcHoadon.MainView = this.gvHoadon;
            this.gcHoadon.Name = "gcHoadon";
            this.gcHoadon.Size = new System.Drawing.Size(644, 376);
            this.gcHoadon.TabIndex = 0;
            this.gcHoadon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoadon});
            // 
            // gvHoadon
            // 
            this.gvHoadon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDHD,
            this.colHDSIM,
            this.colHDNGBD,
            this.colHDNKT,
            this.colHDSPBN,
            this.colHDSPBD,
            this.colHDGIA,
            this.colHDtrangthai});
            this.gvHoadon.GridControl = this.gcHoadon;
            this.gvHoadon.Name = "gvHoadon";
            this.gvHoadon.OptionsFind.AlwaysVisible = true;
            this.gvHoadon.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gvHoadon.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvHoadon_RowClick);
            // 
            // colIDHD
            // 
            this.colIDHD.Caption = "Mã hóa đơn";
            this.colIDHD.FieldName = "IDHD";
            this.colIDHD.Name = "colIDHD";
            this.colIDHD.Visible = true;
            this.colIDHD.VisibleIndex = 0;
            // 
            // colHDSIM
            // 
            this.colHDSIM.Caption = "Mã sim";
            this.colHDSIM.FieldName = "IDsim";
            this.colHDSIM.Name = "colHDSIM";
            this.colHDSIM.Visible = true;
            this.colHDSIM.VisibleIndex = 1;
            // 
            // colHDNGBD
            // 
            this.colHDNGBD.Caption = "Ngày bắt đầu";
            this.colHDNGBD.FieldName = "TGBD";
            this.colHDNGBD.Name = "colHDNGBD";
            this.colHDNGBD.Visible = true;
            this.colHDNGBD.VisibleIndex = 2;
            // 
            // colHDNKT
            // 
            this.colHDNKT.Caption = "Ngày kết thúc";
            this.colHDNKT.FieldName = "TGKT";
            this.colHDNKT.Name = "colHDNKT";
            this.colHDNKT.Visible = true;
            this.colHDNKT.VisibleIndex = 3;
            // 
            // colHDSPBN
            // 
            this.colHDSPBN.Caption = "Sô phút Ban ngày";
            this.colHDSPBN.FieldName = "SophutBN";
            this.colHDSPBN.Name = "colHDSPBN";
            this.colHDSPBN.Visible = true;
            this.colHDSPBN.VisibleIndex = 4;
            // 
            // colHDSPBD
            // 
            this.colHDSPBD.Caption = "Số phút ban đêm";
            this.colHDSPBD.FieldName = "SophutBD";
            this.colHDSPBD.Name = "colHDSPBD";
            this.colHDSPBD.Visible = true;
            this.colHDSPBD.VisibleIndex = 5;
            // 
            // colHDGIA
            // 
            this.colHDGIA.Caption = "Tổng giá tiền";
            this.colHDGIA.FieldName = "TongSoTien";
            this.colHDGIA.Name = "colHDGIA";
            this.colHDGIA.Visible = true;
            this.colHDGIA.VisibleIndex = 6;
            // 
            // colHDtrangthai
            // 
            this.colHDtrangthai.Caption = "Trạng thái";
            this.colHDtrangthai.FieldName = "Trangthai";
            this.colHDtrangthai.Name = "colHDtrangthai";
            this.colHDtrangthai.Visible = true;
            this.colHDtrangthai.VisibleIndex = 7;
            // 
            // btthoigiansudung
            // 
            this.btthoigiansudung.Location = new System.Drawing.Point(564, 151);
            this.btthoigiansudung.Name = "btthoigiansudung";
            this.btthoigiansudung.Size = new System.Drawing.Size(93, 23);
            this.btthoigiansudung.TabIndex = 1;
            this.btthoigiansudung.Text = "Thời gian sử dụng";
            this.btthoigiansudung.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(565, 88);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(92, 23);
            this.btxoa.TabIndex = 1;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(565, 59);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(92, 23);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(565, 30);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(92, 23);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Controls.Add(this.labelControl4);
            this.groupBox3.Controls.Add(this.txtmahoadon);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.labelControl3);
            this.groupBox3.Controls.Add(this.labelControl2);
            this.groupBox3.Controls.Add(this.labelControl1);
            this.groupBox3.Controls.Add(this.txtngabd);
            this.groupBox3.Controls.Add(this.txtsopphutbn);
            this.groupBox3.Controls.Add(this.txtspbd);
            this.groupBox3.Controls.Add(this.txtngkt);
            this.groupBox3.Controls.Add(this.cbMasim);
            this.groupBox3.Controls.Add(this.txttonggia);
            this.groupBox3.Controls.Add(this.cbtrangthai);
            this.groupBox3.Location = new System.Drawing.Point(7, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 151);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(7, 128);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Trạng thái";
            this.labelControl8.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 94);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Tổng giá";
            this.labelControl7.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(247, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Số phút BD";
            this.labelControl6.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(247, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Ngày kết thúc";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(90, 21);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(140, 20);
            this.txtmahoadon.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(247, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Số phút BN";
            this.labelControl5.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(247, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày bắt đầu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã sim";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã hóa đơn";
            // 
            // txtngabd
            // 
            this.txtngabd.EditValue = new System.DateTime(2018, 11, 20, 0, 27, 41, 0);
            this.txtngabd.Location = new System.Drawing.Point(320, 94);
            this.txtngabd.Name = "txtngabd";
            this.txtngabd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngabd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngabd.Properties.DisplayFormat.FormatString = "";
            this.txtngabd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtngabd.Properties.EditFormat.FormatString = "";
            this.txtngabd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtngabd.Properties.Mask.EditMask = "";
            this.txtngabd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtngabd.Size = new System.Drawing.Size(159, 20);
            this.txtngabd.TabIndex = 2;
            // 
            // txtsopphutbn
            // 
            this.txtsopphutbn.EditValue = "";
            this.txtsopphutbn.Location = new System.Drawing.Point(320, 17);
            this.txtsopphutbn.Name = "txtsopphutbn";
            this.txtsopphutbn.Properties.ReadOnly = true;
            this.txtsopphutbn.Size = new System.Drawing.Size(159, 20);
            this.txtsopphutbn.TabIndex = 3;
            this.txtsopphutbn.EditValueChanged += new System.EventHandler(this.popupGalleryEdit1_EditValueChanged);
            // 
            // txtspbd
            // 
            this.txtspbd.EditValue = "";
            this.txtspbd.Location = new System.Drawing.Point(320, 51);
            this.txtspbd.Name = "txtspbd";
            this.txtspbd.Properties.ReadOnly = true;
            this.txtspbd.Size = new System.Drawing.Size(159, 20);
            this.txtspbd.TabIndex = 3;
            this.txtspbd.EditValueChanged += new System.EventHandler(this.popupGalleryEdit2_EditValueChanged);
            // 
            // txtngkt
            // 
            this.txtngkt.EditValue = new System.DateTime(2018, 11, 20, 0, 28, 2, 0);
            this.txtngkt.Location = new System.Drawing.Point(320, 124);
            this.txtngkt.Name = "txtngkt";
            this.txtngkt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngkt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngkt.Properties.DisplayFormat.FormatString = "";
            this.txtngkt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtngkt.Properties.EditFormat.FormatString = "";
            this.txtngkt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtngkt.Properties.Mask.EditMask = "";
            this.txtngkt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtngkt.Size = new System.Drawing.Size(159, 20);
            this.txtngkt.TabIndex = 3;
            this.txtngkt.EditValueChanged += new System.EventHandler(this.popupGalleryEdit2_EditValueChanged);
            // 
            // cbMasim
            // 
            this.cbMasim.EditValue = "1";
            this.cbMasim.Location = new System.Drawing.Point(90, 51);
            this.cbMasim.Name = "cbMasim";
            this.cbMasim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMasim.Size = new System.Drawing.Size(140, 20);
            this.cbMasim.TabIndex = 3;
            this.cbMasim.EditValueChanged += new System.EventHandler(this.popupGalleryEdit1_EditValueChanged);
            // 
            // txttonggia
            // 
            this.txttonggia.EditValue = "";
            this.txttonggia.Location = new System.Drawing.Point(90, 91);
            this.txttonggia.Name = "txttonggia";
            this.txttonggia.Size = new System.Drawing.Size(140, 20);
            this.txttonggia.TabIndex = 3;
            this.txttonggia.EditValueChanged += new System.EventHandler(this.popupGalleryEdit2_EditValueChanged);
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.EditValue = "Chưa thanh toán";
            this.cbtrangthai.Location = new System.Drawing.Point(90, 121);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbtrangthai.Properties.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbtrangthai.Size = new System.Drawing.Size(140, 20);
            this.cbtrangthai.TabIndex = 3;
            this.cbtrangthai.EditValueChanged += new System.EventHandler(this.popupGalleryEdit2_EditValueChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // formHoadon
            // 
            this.Controls.Add(this.panelControl1);
            this.Name = "formHoadon";
            this.Size = new System.Drawing.Size(1419, 585);
            this.Load += new System.EventHandler(this.formHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThoigiansudung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThoigiansudung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoadon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngabd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngabd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsopphutbn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtspbd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngkt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngkt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMasim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttonggia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbtrangthai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void popupGalleryEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void popupGalleryEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HOADON hOADON = new HOADON();
            hOADON.IDHD = txtmahoadon.EditValue.ToString();

            if (hOADON.Exits_KH_byMa(hOADON.IDHD))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                hOADON.IDsim = cbMasim.EditValue.ToString();
                hOADON.TGBD = DateTime.Parse(txtngabd.EditValue.ToString());
                hOADON.TGKT = DateTime.Parse(txtngkt.EditValue.ToString());
                hOADON.SophutBN = hOADON.TinhSophutbanngay(hOADON);
                hOADON.SophutBD = hOADON.TinhSophutbandem(hOADON);
                hOADON.TongSoTien = hOADON.Tinhtonggiatien(hOADON);
                hOADON.Trangthai = cbtrangthai.EditValue.ToString();
                if (!hOADON.Kietrangayhoadon(hOADON))
                {
                    MessageBox.Show("Khoảng Thời gian tính hóa đơn đã được tính trước đó, Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        hOADON.insert_HOADON(hOADON);
                        MessageBox.Show("Thêm Hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Thêm Hóa đơn không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Load_HoaDon();
                }
               
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            HOADON hOADON = new HOADON();
            hOADON.IDHD = txtmahoadon.EditValue.ToString();

            if (!hOADON.Exits_KH_byMa(hOADON.IDHD))
            {
                MessageBox.Show("Mã hóa đơn Không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                hOADON.IDsim = cbMasim.EditValue.ToString();
                hOADON.TGBD = DateTime.Parse(txtngabd.EditValue.ToString());
                hOADON.TGKT = DateTime.Parse(txtngkt.EditValue.ToString());
                hOADON.SophutBN = hOADON.TinhSophutbanngay(hOADON);
                hOADON.SophutBD = hOADON.TinhSophutbandem(hOADON);
                hOADON.TongSoTien = hOADON.Tinhtonggiatien(hOADON);
                hOADON.Trangthai = cbtrangthai.EditValue.ToString();
                if (!hOADON.Kietrangayhoadon(hOADON))
                {
                    MessageBox.Show("Khoảng Thời gian tính hóa đơn đã được tính trước đó, Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        hOADON.update_Hoadon(hOADON);
                        MessageBox.Show("Chỉnh sửa thông tin khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Chỉnh sửa thông tin không thành công!", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Load_HoaDon();
                }
                
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (txtmahoadon.EditValue != null)
            {
                dr = MessageBox.Show("Bạn có chắc chắn xóa hóa đơn có mã: " + txtmahoadon.EditValue.ToString(), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        HOADON hOADON = new HOADON();
                        hOADON.IDHD = txtmahoadon.EditValue.ToString();
                        hOADON.delete_HOADON(hOADON);
                        MessageBox.Show("Xóa hóa đơn có mã: " + hOADON.IDHD, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_HoaDon();
                    }
                    catch
                    {
                        MessageBox.Show("Xóa hóa đơn không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn mã hóa đơn cho thao tác xóa" , "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            HOADON hOADON = new HOADON();
            if (txtmahoadon.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn mã hóa đơn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hOADON.IDHD = txtmahoadon.EditValue.ToString();

                if (!hOADON.Exits_KH_byMa(hOADON.IDHD))
                {
                    MessageBox.Show("Mã hóa đơn Không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    hOADON = hOADON.GetByMa(hOADON.IDHD);
                    THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
                    gcThoigiansudung.DataSource = tHOIGIANSUDUNG.Get_by_hoadon(hOADON);
                }
            }
            
        }

        private void formHoadon_Load(object sender, EventArgs e)
        {
            Load_Thoigiansudung();
            Load_cb_IDSIM();
            Load_HoaDon();
        }
        public void Load_HoaDon()
        {
            HOADON hOADON = new HOADON();
            gcHoadon.DataSource = hOADON.GetAll();
        }
        public void Load_Thoigiansudung()
        {
            THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
            gcThoigiansudung.DataSource = tHOIGIANSUDUNG.GetAll();
        }
        public void Load_cb_IDSIM()
        {
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            var list = tHONGTINSIM.GetAllIDSIM();
            foreach (var item in list)
              cbMasim.Properties.Items.Add(item);
        }

        private void gvHoadon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            List<HOADON> hOADONs= ((List<HOADON>)gvHoadon.DataSource);
            HOADON hOADON = hOADONs[gvHoadon.FocusedRowHandle];
            txtmahoadon.Text = hOADON.IDHD;
            cbMasim.Text = hOADON.IDsim;
            txtngabd.Text = hOADON.TGBD.ToString();
            txtngkt.Text = hOADON.TGKT.ToString();
            txtsopphutbn.Text = hOADON.SophutBN.ToString();
            txtspbd.Text = hOADON.SophutBD.ToString();
            txttonggia.Text = hOADON.TongSoTien.ToString();
            cbtrangthai.Text = hOADON.Trangthai;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_Thoigiansudung();
        }
       Bitmap bmp;
        private void buthoadon_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width , this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();
            if (txtmahoadon.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                HOADON hOADON = new HOADON();
                hOADON.IDHD = txtmahoadon.EditValue.ToString();

                if (!hOADON.Exits_KH_byMa(hOADON.IDHD))
                {
                    MessageBox.Show("Không tồn tại hóa đơn có mã:" + hOADON.IDHD.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            HOADON hOADON = new HOADON();
            hOADON.IDHD = txtmahoadon.EditValue.ToString();
           
                hOADON = hOADON.GetByMa(hOADON.IDHD);
                KHACHHANG kHACHHANG = new KHACHHANG();
                kHACHHANG = kHACHHANG.Get_KHACHHANG_BySIM(hOADON.IDsim)[0];
                THONGTINSIM tHONGTINSIM = new THONGTINSIM();
                tHONGTINSIM = tHONGTINSIM.GetByMa(hOADON.IDsim);
            // ve hoa don
                Graphics graphic = e.Graphics;
                Font font = new Font("Courier New", 12);
                float FontHeight = font.GetHeight();
                int startX = 10;
                int startY = 10;
                int offset = 40;

                graphic.DrawString("HÓA ĐƠN CƯỚC ĐIỆN THOẠI", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
                // string top = "Tên Sản Phẩm".PadRight(24) + "Thành Tiền";
                // graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);

                graphic.DrawString("Mã Hóa đơn", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(hOADON.IDHD, new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

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


                graphic.DrawString("THÔNG TIN HÓA ĐƠN", new Font("Courier New", 15), new SolidBrush(Color.Black), startX, startY + offset);
                //int index = 0;
                //foreach (string item in lsbTenSanPham.Items)
                //{
                //    graphic.DrawString(item, font, new SolidBrush(Color.Black), startX, startY + offset);
                //    graphic.DrawString(lsbThanhTien.Items[index++].ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
                //    offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                //}

                //offset = offset + 20; //make some room so that the total stands out.

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Mã sim", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(hOADON.IDsim, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Số điện thoại", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(tHONGTINSIM.Sdt, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Ngày đăng ký:", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(tHONGTINSIM.NgayDK.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Thời gian bắt đầu ", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(hOADON.TGBD.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Thời gian kết thúc ", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(hOADON.TGKT.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Số phút ban ngày", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(hOADON.SophutBN.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Số phút ban đêm ", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(hOADON.SophutBD.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("Tổng số tiền", font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(hOADON.TongSoTien.ToString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

                offset = offset + (int)FontHeight; //make the spacing consistent
                graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent

                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString("XIN QUÝ KHÁCH VUI LÒNG THANH TOÁN TRƯỚC 15 NGÀY KỂ TỪ NGÀY XUẤT HÓA ĐƠN( " + DateTime.Now.ToString() + ")", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
                graphic.DrawString(" CẢM ƠN QUÝ KHÁCH ĐÃ SỬ DỤNG DỊCH VỤ CỦA CHÚNG TÔI,", font, new SolidBrush(Color.Black), startX, startY + offset);
               

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
       
    }
}
