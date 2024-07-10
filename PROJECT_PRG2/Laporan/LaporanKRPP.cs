using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.Laporan
{
    public partial class LaporanKRPP : Form
    {
        public LaporanKRPP()
        {
            InitializeComponent();
        }

        private void KRPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repKRPP.LaporanMahasiswaKRPP' table. You can move, or remove it, as needed.
            this.laporanMahasiswaKRPPTableAdapter.Fill(this.repKRPP.LaporanMahasiswaKRPP);
            cbFilter.Text = "-- Filter KRPP --";
            this.reportViewer1.RefreshReport();
        }
    }
}
