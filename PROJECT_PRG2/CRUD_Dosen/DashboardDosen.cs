using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Dosen
{
    public partial class DashboardDosen : Form
    {
        public DashboardDosen()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardDosen dashboardDosen = new DashboardDosen();
            dashboardDosen.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InputDosen inputDosen = new InputDosen();
            inputDosen.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewDosen viewDosen = new ViewDosen();
            viewDosen.Show();
            this.Hide();
        }

        private void btnUpdateDel_Click(object sender, EventArgs e)
        {
            UpdateDeleteDosen updateDeleteDosen = new UpdateDeleteDosen();
            updateDeleteDosen.Show();
            this.Hide();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            LoginSbgTenDik loginSbgTenDik = new LoginSbgTenDik();
            loginSbgTenDik.Show();
            this.Hide();
        }
    }
}
