using PROJECT_PRG2.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint,
                          true);
            this.UpdateStyles();
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            DashboardUtama tampilanAwal = new DashboardUtama();
            tampilanAwal.Show();
            this.Hide();
        }
    }
}
