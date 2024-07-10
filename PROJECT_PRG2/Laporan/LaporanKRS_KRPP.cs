using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.Laporan
{
    public partial class LaporanKRS_KRPP : Form
    {
        public LaporanKRS_KRPP()
        {
            InitializeComponent();
        }

        private void LaporanKRS_KRPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repMabres.MahasiswaBerprestasi' table. You can move, or remove it, as needed.
            this.mahasiswaBerprestasiTableAdapter.Fill(this.repMabres.MahasiswaBerprestasi);
            this.reportViewer1.RefreshReport();
        }
    }
}
