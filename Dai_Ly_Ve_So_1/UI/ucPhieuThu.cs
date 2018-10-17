using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dai_Ly_Ve_So_1.BUS;
using Dai_Ly_Ve_So_1.DAL;

namespace Dai_Ly_Ve_So_1.UI
{
    public partial class ucPhieuThu : UserControl
    {
        BusPhieuThu busPhieuThu = new BusPhieuThu();
        public ucPhieuThu()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            gcDanhsachphieuthu.DataSource = busPhieuThu.GetAll();
        }
        private void ucPhieuThu1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        public void resetForm()
        {
            txt_MaPhieuThu.Text = "";
            txt_MaCongNo.Text = "";
            txt_Ngay.Text = "";
            txt_SotienNop.Text = "";
        }
        private void gvPhieuthu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txt_MaPhieuThu.Text = gvPhieuthu.GetRowCellValue(gvPhieuthu.FocusedRowHandle, "MaPhieuThu").ToString();
            txt_MaCongNo.Text = gvPhieuthu.GetRowCellValue(gvPhieuthu.FocusedRowHandle, "MaCongNo").ToString();
            txt_Ngay.Text = gvPhieuthu.GetRowCellValue(gvPhieuthu.FocusedRowHandle, "NgayThu").ToString();
            txt_SotienNop.Text = gvPhieuthu.GetRowCellValue(gvPhieuthu.FocusedRowHandle, "SoTienNop").ToString();
            CB_flag.SelectedValue = gvPhieuthu.GetRowCellValue(gvPhieuthu.FocusedRowHandle, "Flag").ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuThu pt = new PhieuThu();
                pt.MaPhieuThu = txt_MaPhieuThu.Text;
                pt.MaCongNo = txt_MaCongNo.Text;
                pt.NgayThu = DateTime.Parse(txt_Ngay.Text);
                pt.SoTienNop = int.Parse(txt_SotienNop.Text);

                if (CB_flag.SelectedIndex == 0)
                {
                    pt.Flag = 0;
                }
                else pt.Flag = 1;

                busPhieuThu.insert_PhieuThu(pt);
                Load_Data();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");

            }
            resetForm();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuThu pt = new PhieuThu();
                pt.MaPhieuThu = txt_MaPhieuThu.Text;
                pt.MaCongNo = txt_MaCongNo.Text;
                pt.NgayThu = DateTime.Parse(txt_Ngay.Text);
                pt.SoTienNop = int.Parse(txt_SotienNop.Text);
                if (CB_flag.SelectedIndex == 0)
                {
                    pt.Flag = 0;
                }
                else
                    pt.Flag = 1;
                busPhieuThu.update_PhieuThu(pt);
                Load_Data();

            }
            catch
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ dữ liệu");
            }
            resetForm();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show(String.Format("Bạn có muốn xóa phiếu thu này '{0}' không ?", colMaPhieuThu), "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                busPhieuThu.delete_PhieuThu(txt_MaPhieuThu.Text);
                Load_Data();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn phiếu cần xóa");
            }
            resetForm();
        }
    }
}
