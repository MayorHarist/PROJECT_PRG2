using PROJECT_PRG2.CRUD_Prodi;
using PROJECT_PRG2.Transaksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.Dashboard
{
    public partial class DashboardMahasiswa : Form
    {
        private bool panelDataMuncul = false;
        private bool panelTransaksiMuncul = false;
        private int step = 10;
        public DashboardMahasiswa()
        {
            InitializeComponent();
            panelData.Height = 0;
            panelTransaksi.Height = 0;
            timerData.Interval = 10;
            timerData.Tick += timerData_Tick;
            timerTRS.Interval = 10;
            timerTRS.Tick += timerTRS_Tick;
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            if (panelDataMuncul)
            {
                if (panelData.Height < 158)
                {
                    panelData.Height += step;
                    if (panelData.Height >= 158)
                    {
                        panelData.Height = 158;
                        timerData.Stop();
                    }
                }
            }
            else
            {
                if (panelData.Height > 0)
                {
                    panelData.Height -= step;
                    if (panelData.Height <= 0)
                    {
                        panelData.Height = 0;
                        timerData.Stop();
                    }
                }
            }
        }

        private void timerTRS_Tick(object sender, EventArgs e)
        {
            if (panelTransaksiMuncul)
            {
                if (panelTransaksi.Height < 63)
                {
                    panelTransaksi.Height += step;
                    if (panelTransaksi.Height >= 63)
                    {
                        panelTransaksi.Height = 63;
                        timerTRS.Stop();
                    }
                }
            }
            else
            {
                if (panelTransaksi.Height > 0)
                {
                    panelTransaksi.Height -= step;
                    if (panelTransaksi.Height <= 0)
                    {
                        panelTransaksi.Height = 0;
                        timerTRS.Stop();
                    }
                }
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            panelDataMuncul = !panelDataMuncul;
            timerData.Start();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            panelTransaksiMuncul = !panelTransaksiMuncul;
            timerTRS.Start();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnTrsKRPP_Click(object sender, EventArgs e)
        {
            trsKRPP trsKRPP = new trsKRPP();
            // Atur parent form UpDelet_Prodi ke panelMain
            trsKRPP.TopLevel = false;
            trsKRPP.AutoScroll = true;
            panelMain.Controls.Add(trsKRPP);
            trsKRPP.Show();
        }
    }
}
