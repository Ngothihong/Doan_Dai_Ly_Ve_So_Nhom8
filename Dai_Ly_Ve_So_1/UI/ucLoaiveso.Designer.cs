namespace Dai_Ly_Ve_So_1.UI
{
    partial class ucLoaiveso
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDSVeso = new DevExpress.XtraGrid.GridControl();
            this.gvDSveso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaloaive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlag = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSVeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSveso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(700, 403);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.gcDSVeso);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(696, 399);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách vé sô";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(78, 205);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Xóa";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(129, 157);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Sửa";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(20, 157);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Thêm";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(129, 90);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tỉnh phát hành";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(129, 46);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã vé";
            // 
            // gcDSVeso
            // 
            this.gcDSVeso.Location = new System.Drawing.Point(254, 23);
            this.gcDSVeso.MainView = this.gvDSveso;
            this.gcDSVeso.Name = "gcDSVeso";
            this.gcDSVeso.Size = new System.Drawing.Size(400, 312);
            this.gcDSVeso.TabIndex = 0;
            this.gcDSVeso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSveso});
            // 
            // gvDSveso
            // 
            this.gvDSveso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaloaive,
            this.colTinh,
            this.colGiave,
            this.colNgay,
            this.colFlag});
            this.gvDSveso.GridControl = this.gcDSVeso;
            this.gvDSveso.Name = "gvDSveso";
            this.gvDSveso.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDSveso_RowClick);
            // 
            // colMaloaive
            // 
            this.colMaloaive.Caption = "Mã vé";
            this.colMaloaive.FieldName = "MaLoaiVeSo";
            this.colMaloaive.Name = "colMaloaive";
            this.colMaloaive.Visible = true;
            this.colMaloaive.VisibleIndex = 0;
            // 
            // colTinh
            // 
            this.colTinh.Caption = "Tỉnh phát hành";
            this.colTinh.FieldName = "Tinh";
            this.colTinh.Name = "colTinh";
            this.colTinh.Visible = true;
            this.colTinh.VisibleIndex = 1;
            // 
            // colGiave
            // 
            this.colGiave.Caption = "Giá vé";
            this.colGiave.FieldName = "GiaVe";
            this.colGiave.Name = "colGiave";
            this.colGiave.Visible = true;
            this.colGiave.VisibleIndex = 2;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 3;
            // 
            // colFlag
            // 
            this.colFlag.Caption = "Trạng thái";
            this.colFlag.FieldName = "falg";
            this.colFlag.Name = "colFlag";
            this.colFlag.Visible = true;
            this.colFlag.VisibleIndex = 4;
            // 
            // ucLoaiveso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucLoaiveso";
            this.Size = new System.Drawing.Size(700, 403);
            this.Load += new System.EventHandler(this.ucLoaiveso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSVeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSveso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcDSVeso;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSveso;
        private DevExpress.XtraGrid.Columns.GridColumn colMaloaive;
        private DevExpress.XtraGrid.Columns.GridColumn colTinh;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colGiave;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colFlag;
    }
}
