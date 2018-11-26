namespace ThanhThanh.UI
{
    partial class formCuocDT
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.btthem = new DevExpress.XtraEditors.SimpleButton();
            this.txtgia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtmacuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtngayapdung = new DevExpress.XtraEditors.DateEdit();
            this.txtTGBD = new DevExpress.XtraEditors.TimeSpanEdit();
            this.txtTGKT = new DevExpress.XtraEditors.TimeSpanEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gcCuocthuebao = new DevExpress.XtraGrid.GridControl();
            this.gvCuocThuebao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmacuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloaicuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGKT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtloaicuoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngayapdung.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngayapdung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTGBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTGKT.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCuocthuebao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuocThuebao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtloaicuoc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtmacuoc);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtngayapdung);
            this.groupBox1.Controls.Add(this.txtTGBD);
            this.groupBox1.Controls.Add(this.txtTGKT);
            this.groupBox1.Controls.Add(this.txtloaicuoc);
            this.groupBox1.Location = new System.Drawing.Point(17, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(269, 407);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(161, 407);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 3;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(47, 407);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 3;
            this.btthem.Text = "Thêm";
            this.btthem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(107, 193);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(129, 20);
            this.txtgia.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 236);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Ngày áp dụng";
            this.labelControl4.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtmacuoc
            // 
            this.txtmacuoc.Location = new System.Drawing.Point(107, 29);
            this.txtmacuoc.Name = "txtmacuoc";
            this.txtmacuoc.Size = new System.Drawing.Size(129, 20);
            this.txtmacuoc.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 152);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Thời gian kết thúc";
            this.labelControl6.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 196);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(15, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Giá";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 112);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Thời gian bắt đầu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Loại cước";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã cước";
            // 
            // txtngayapdung
            // 
            this.txtngayapdung.EditValue = null;
            this.txtngayapdung.Location = new System.Drawing.Point(107, 233);
            this.txtngayapdung.Name = "txtngayapdung";
            this.txtngayapdung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngayapdung.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtngayapdung.Properties.DisplayFormat.FormatString = "";
            this.txtngayapdung.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtngayapdung.Properties.EditFormat.FormatString = "";
            this.txtngayapdung.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtngayapdung.Properties.Mask.EditMask = "";
            this.txtngayapdung.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtngayapdung.Size = new System.Drawing.Size(129, 20);
            this.txtngayapdung.TabIndex = 2;
            // 
            // txtTGBD
            // 
            this.txtTGBD.EditValue = null;
            this.txtTGBD.Location = new System.Drawing.Point(107, 109);
            this.txtTGBD.Name = "txtTGBD";
            this.txtTGBD.Properties.AllowEditDays = false;
            this.txtTGBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTGBD.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTGBD.Properties.Mask.EditMask = "";
            this.txtTGBD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTGBD.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.txtTGBD.Size = new System.Drawing.Size(129, 20);
            this.txtTGBD.TabIndex = 2;
            // 
            // txtTGKT
            // 
            this.txtTGKT.EditValue = null;
            this.txtTGKT.Location = new System.Drawing.Point(107, 149);
            this.txtTGKT.Name = "txtTGKT";
            this.txtTGKT.Properties.AllowEditDays = false;
            this.txtTGKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTGKT.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTGKT.Properties.Mask.EditMask = "";
            this.txtTGKT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTGKT.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.txtTGKT.Size = new System.Drawing.Size(129, 20);
            this.txtTGKT.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcCuocthuebao);
            this.groupBox2.Location = new System.Drawing.Point(382, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 458);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách cước";
            // 
            // gcCuocthuebao
            // 
            this.gcCuocthuebao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCuocthuebao.Location = new System.Drawing.Point(3, 16);
            this.gcCuocthuebao.MainView = this.gvCuocThuebao;
            this.gcCuocthuebao.Name = "gcCuocthuebao";
            this.gcCuocthuebao.Size = new System.Drawing.Size(507, 439);
            this.gcCuocthuebao.TabIndex = 0;
            this.gcCuocthuebao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCuocThuebao});
            // 
            // gvCuocThuebao
            // 
            this.gvCuocThuebao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmacuoc,
            this.colloaicuoc,
            this.colTGBD,
            this.colTGKT,
            this.colGia,
            this.colNgay});
            this.gvCuocThuebao.GridControl = this.gcCuocthuebao;
            this.gvCuocThuebao.Name = "gvCuocThuebao";
            this.gvCuocThuebao.OptionsFind.AlwaysVisible = true;
            this.gvCuocThuebao.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCuocThuebao_RowClick);
            // 
            // colmacuoc
            // 
            this.colmacuoc.Caption = "Mã cước";
            this.colmacuoc.FieldName = "IDcuoc";
            this.colmacuoc.Name = "colmacuoc";
            this.colmacuoc.Visible = true;
            this.colmacuoc.VisibleIndex = 0;
            // 
            // colloaicuoc
            // 
            this.colloaicuoc.Caption = "Loại cước";
            this.colloaicuoc.FieldName = "Tencuoc";
            this.colloaicuoc.Name = "colloaicuoc";
            this.colloaicuoc.Visible = true;
            this.colloaicuoc.VisibleIndex = 1;
            // 
            // colTGBD
            // 
            this.colTGBD.Caption = "TGBD";
            this.colTGBD.FieldName = "TGBD";
            this.colTGBD.Name = "colTGBD";
            this.colTGBD.Visible = true;
            this.colTGBD.VisibleIndex = 2;
            // 
            // colTGKT
            // 
            this.colTGKT.Caption = "TGKT";
            this.colTGKT.FieldName = "TGKT";
            this.colTGKT.Name = "colTGKT";
            this.colTGKT.Visible = true;
            this.colTGKT.VisibleIndex = 3;
            // 
            // colGia
            // 
            this.colGia.Caption = "Giá";
            this.colGia.FieldName = "Gia";
            this.colGia.Name = "colGia";
            this.colGia.Visible = true;
            this.colGia.VisibleIndex = 4;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày áp dụng";
            this.colNgay.FieldName = "Ngayapdung";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 5;
            // 
            // txtloaicuoc
            // 
            this.txtloaicuoc.EditValue = "Banngay";
            this.txtloaicuoc.Location = new System.Drawing.Point(107, 69);
            this.txtloaicuoc.Name = "txtloaicuoc";
            this.txtloaicuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtloaicuoc.Properties.Items.AddRange(new object[] {
            "Banngay",
            "Bandem"});
            this.txtloaicuoc.Size = new System.Drawing.Size(129, 20);
            this.txtloaicuoc.TabIndex = 2;
            // 
            // formCuocDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formCuocDT";
            this.Size = new System.Drawing.Size(907, 474);
            this.Load += new System.EventHandler(this.formCuocDT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmacuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngayapdung.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtngayapdung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTGBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTGKT.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCuocthuebao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuocThuebao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtloaicuoc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtmacuoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btxoa;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private DevExpress.XtraEditors.SimpleButton btthem;
        private DevExpress.XtraEditors.TextEdit txtgia;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtngayapdung;
        private DevExpress.XtraGrid.GridControl gcCuocthuebao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCuocThuebao;
        private DevExpress.XtraGrid.Columns.GridColumn colmacuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colloaicuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colTGBD;
        private DevExpress.XtraGrid.Columns.GridColumn colTGKT;
        private DevExpress.XtraGrid.Columns.GridColumn colGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TimeSpanEdit txtTGBD;
        private DevExpress.XtraEditors.TimeSpanEdit txtTGKT;
        private DevExpress.XtraEditors.ComboBoxEdit txtloaicuoc;
    }
}
