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
    public partial class LaporanKRS : Form
    {
        public LaporanKRS()
        {
            InitializeComponent();
        }

        private void KRS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repKRS.LaporanMahasiswaBerprestasi' table. You can move, or remove it, as needed.
            this.laporanMahasiswaBerprestasiTableAdapter.Fill(this.repKRS.LaporanMahasiswaBerprestasi);
            this.reportViewer1.RefreshReport();
        }
    }
}
