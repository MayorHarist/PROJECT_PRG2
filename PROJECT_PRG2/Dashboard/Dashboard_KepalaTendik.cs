using PROJECT_PRG2.CRUD_PosisiPrestasi;
using PROJECT_PRG2.CRUD_Tendik;
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
    public partial class Dashboard_KepalaTendik : Form
    {
        private bool panelDataMuncul = false;
        private bool panelLaporanMuncul = false;
        private int step = 10;
        public Dashboard_KepalaTendik()
        {
            InitializeComponent();
            panelData.Height = 0;
            panelLaporan.Height = 0;
            timerData.Interval = 10;
            timerData.Tick += timerData_Tick;
            timerLaporan.Interval = 10;
            timerLaporan.Tick += timerLaporan_Tick;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            if (panelDataMuncul)
            {
                if (panelData.Height < 64)
                {
                    panelData.Height += step;
                    if (panelData.Height >= 64)
                    {
                        panelData.Height = 64;
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

        private void timerLaporan_Tick(object sender, EventArgs e)
        {
            if (panelLaporanMuncul)
            {
                if (panelLaporan.Height < 103)
                {
                    panelLaporan.Height += step;
                    if (panelLaporan.Height >= 103)
                    {
                        panelLaporan.Height = 103;
                        timerLaporan.Stop();
                    }
                }
            }
            else
            {
                if (panelLaporan.Height > 0)
                {
                    panelLaporan.Height -= step;
                    if (panelLaporan.Height <= 0)
                    {
                        panelLaporan.Height = 0;
                        timerLaporan.Stop();
                    }
                }
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            panelDataMuncul = !panelDataMuncul;
            timerData.Start();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            panelLaporanMuncul = !panelLaporanMuncul;
            timerLaporan.Start();
        }

        private void btnProdi_Click(object sender, EventArgs e)
        {
            // Buat instance form UDPosisPrestasi
            UpTendik upTendik = new UpTendik();
            // Atur parent form UpDelet_Prodi ke panelMain
            upTendik.TopLevel = false;
            upTendik.AutoScroll = true;
            panelMain.Controls.Add(upTendik);
            upTendik.Show();
        }
    }
}
