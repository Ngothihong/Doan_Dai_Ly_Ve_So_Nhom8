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


namespace Dai_Ly_Ve_So_1.UI
{
    public partial class ucLoaiveso : UserControl
    {
        BusLoaiveso busLoaiveso = new BusLoaiveso();
        public ucLoaiveso()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucLoaiveso_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            gcDSVeso.DataSource = busLoaiveso.GetAll();
        }

        private void gvDSveso_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }
    }
}
