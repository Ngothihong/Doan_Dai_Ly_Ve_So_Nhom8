namespace Dai_Ly_Ve_So_1.UI
{
    partial class ucPhieuThu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label1 = new System.Windows.Forms.Label();
            this.gcDanhsachphieuthu = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuthu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCongNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienNop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btsua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_flag = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SotienNop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Ngay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaPhieuThu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaCongNo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachphieuthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SotienNop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhieuThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCongNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(906, 532);
            this.panelControl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(489, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(43, 100);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(108, 8);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(187, 21);
            this.txt_TimKiem.TabIndex = 4;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txt_TimKiem);
            this.splitContainerControl1.Panel1.Controls.Add(this.gcDanhsachphieuthu);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(902, 528);
            this.splitContainerControl1.SplitterPosition = 484;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm Kiếm";
            // 
            // gcDanhsachphieuthu
            // 
            this.gcDanhsachphieuthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhsachphieuthu.Location = new System.Drawing.Point(0, 0);
            this.gcDanhsachphieuthu.MainView = this.gvPhieuthu;
            this.gcDanhsachphieuthu.Name = "gcDanhsachphieuthu";
            this.gcDanhsachphieuthu.Size = new System.Drawing.Size(484, 528);
            this.gcDanhsachphieuthu.TabIndex = 1;
            this.gcDanhsachphieuthu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuthu});
            // 
            // gvPhieuthu
            // 
            this.gvPhieuthu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuThu,
            this.colMaCongNo,
            this.colNgayThu,
            this.colSoTienNop,
            this.colFlag});
            this.gvPhieuthu.GridControl = this.gcDanhsachphieuthu;
            this.gvPhieuthu.Name = "gvPhieuthu";
            this.gvPhieuthu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPhieuthu_RowClick);
            // 
            // colMaPhieuThu
            // 
            this.colMaPhieuThu.Caption = "Mã phiếu thu";
            this.colMaPhieuThu.FieldName = "MaPhieuThu";
            this.colMaPhieuThu.Name = "colMaPhieuThu";
            this.colMaPhieuThu.OptionsColumn.AllowEdit = false;
            this.colMaPhieuThu.Visible = true;
            this.colMaPhieuThu.VisibleIndex = 0;
            // 
            // colMaCongNo
            // 
            this.colMaCongNo.Caption = "Mã công nợ";
            this.colMaCongNo.FieldName = "MaCongNo";
            this.colMaCongNo.Name = "colMaCongNo";
            this.colMaCongNo.OptionsColumn.AllowEdit = false;
            this.colMaCongNo.Visible = true;
            this.colMaCongNo.VisibleIndex = 1;
            // 
            // colNgayThu
            // 
            this.colNgayThu.Caption = "Ngày thu";
            this.colNgayThu.FieldName = "NgayThu";
            this.colNgayThu.Name = "colNgayThu";
            this.colNgayThu.OptionsColumn.AllowEdit = false;
            this.colNgayThu.Visible = true;
            this.colNgayThu.VisibleIndex = 2;
            // 
            // colSoTienNop
            // 
            this.colSoTienNop.Caption = "Số tiền nộp";
            this.colSoTienNop.FieldName = "SoTienNop";
            this.colSoTienNop.Name = "colSoTienNop";
            this.colSoTienNop.OptionsColumn.AllowEdit = false;
            this.colSoTienNop.Visible = true;
            this.colSoTienNop.VisibleIndex = 3;
            // 
            // colFlag
            // 
            this.colFlag.Caption = "Trạng thái";
            this.colFlag.FieldName = "Flag";
            this.colFlag.Name = "colFlag";
            this.colFlag.OptionsColumn.AllowEdit = false;
            this.colFlag.Visible = true;
            this.colFlag.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBox2);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(413, 528);
            this.panelControl2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Location = new System.Drawing.Point(17, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(23, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(237, 10);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(133, 10);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 0;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_flag);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.txt_SotienNop);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txt_Ngay);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txt_MaPhieuThu);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txt_MaCongNo);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu thu:";
            // 
            // CB_flag
            // 
            this.CB_flag.FormattingEnabled = true;
            this.CB_flag.Items.AddRange(new object[] {
            "Đã Thu",
            "Chưa Thu"});
            this.CB_flag.Location = new System.Drawing.Point(124, 197);
            this.CB_flag.Name = "CB_flag";
            this.CB_flag.Size = new System.Drawing.Size(146, 21);
            this.CB_flag.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(36, 200);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Trạng thái:";
            // 
            // txt_SotienNop
            // 
            this.txt_SotienNop.Location = new System.Drawing.Point(124, 161);
            this.txt_SotienNop.Name = "txt_SotienNop";
            this.txt_SotienNop.Size = new System.Drawing.Size(146, 20);
            this.txt_SotienNop.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(36, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "So tiền nộp:";
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.Location = new System.Drawing.Point(124, 125);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(146, 20);
            this.txt_Ngay.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Công Nợ:";
            // 
            // txt_MaPhieuThu
            // 
            this.txt_MaPhieuThu.Location = new System.Drawing.Point(124, 51);
            this.txt_MaPhieuThu.Name = "txt_MaPhieuThu";
            this.txt_MaPhieuThu.Size = new System.Drawing.Size(146, 20);
            this.txt_MaPhieuThu.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã phiếu thu:";
            // 
            // txt_MaCongNo
            // 
            this.txt_MaCongNo.Location = new System.Drawing.Point(124, 87);
            this.txt_MaCongNo.Name = "txt_MaCongNo";
            this.txt_MaCongNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_MaCongNo.Size = new System.Drawing.Size(146, 20);
            this.txt_MaCongNo.TabIndex = 1;
            // 
            // ucPhieuThu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucPhieuThu1";
            this.Size = new System.Drawing.Size(906, 532);
            this.Load += new System.EventHandler(this.ucPhieuThu1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhsachphieuthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SotienNop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhieuThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCongNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private DevExpress.XtraGrid.GridControl gcDanhsachphieuthu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuthu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCongNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienNop;
        private DevExpress.XtraGrid.Columns.GridColumn colFlag;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_flag;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_SotienNop;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_Ngay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_MaPhieuThu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txt_MaCongNo;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
