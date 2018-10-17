using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dai_Ly_Ve_So_1.DAL;
using Dai_Ly_Ve_So_1.BUS;

namespace Dai_Ly_Ve_So_1.UI
{
    public partial class ucPhieuChi : UserControl
    {
        BusPhieuChi busPhieuChi = new BusPhieuChi();
        public ucPhieuChi()
        {
            InitializeComponent();
        }

        private void ucPhieuChi_Load(object sender, EventArgs e)
        {
            load_Data();
        }
        public void load_Data()
        {
            gcDanhSachPhieuChi.DataSource = busPhieuChi.GetAll();
        }
        public void resetForm()
        {
            txtMaPhieuChi.Text = "";
            txtMaPhatHanh.Text = "";
            txtNgay.Text = "";
            txtNoiDung.Text = "";
            txtSoTien.Text = "";
        }
        private void gvPhieuChi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMaPhieuChi.Text = gvPhieuChi.GetRowCellValue(gvPhieuChi.FocusedRowHandle, "MaPhieuChi").ToString();
            txtMaPhatHanh.Text = gvPhieuChi.GetRowCellValue(gvPhieuChi.FocusedRowHandle, "MaPhatHanh").ToString();
            txtNgay.Text = gvPhieuChi.GetRowCellValue(gvPhieuChi.FocusedRowHandle, "Ngay").ToString();
            txtNoiDung.Text = gvPhieuChi.GetRowCellValue(gvPhieuChi.FocusedRowHandle, "NoiDung").ToString();
            txtSoTien.Text = gvPhieuChi.GetRowCellValue(gvPhieuChi.FocusedRowHandle, "SoTien").ToString();


        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuChi pc = new PhieuChi();
                QLVESODataContext db = new QLVESODataContext();
                pc.MaPhieuChi = txtMaPhieuChi.Text;
                pc.MaPhatHanh = txtMaPhatHanh.Text;
                pc.Ngay = DateTime.Parse(txtNgay.Text);
                pc.NoiDung = txtNoiDung.Text;
                pc.SoTien = int.Parse(txtSoTien.Text);

                busPhieuChi.insert_PhieuChi(pc);
                ucPhieuChi_Load(sender, e);
            }

            catch
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ dữ liệu");

            }
            resetForm();

        }

        private void btnsuaPC_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuChi pc = new PhieuChi();
                QLVESODataContext db = new QLVESODataContext();
                pc = db.PhieuChis.Where(s => s.MaPhieuChi == txtMaPhieuChi.Text).Single();
                pc.MaPhieuChi = txtMaPhieuChi.Text;
                pc.MaPhatHanh = txtMaPhatHanh.Text;
                pc.Ngay = DateTime.Parse(txtNgay.Text);
                pc.NoiDung = txtNoiDung.Text;
                pc.SoTien = int.Parse(txtSoTien.Text);
                busPhieuChi.update_PhieuChi(pc);
                ucPhieuChi_Load(sender, e);
            }

            catch
            {
                MessageBox.Show("Kiểm tra lại dữ liệu");

            }
            resetForm();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show(String.Format("Bạn có muốn xóa phiếu thu này '{0}' không ?", colMaPhieuChi), "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                busPhieuChi.delete_PhieuChi(txtMaPhieuChi.Text);
                ucPhieuChi_Load(sender, e);
            }

            catch
            {
                MessageBox.Show("Chọn Phiếu bạn muốn xóa");

            }
            resetForm();
        }
    }
}
