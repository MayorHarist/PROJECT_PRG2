using PROJECT_PRG2.CRUD_PosisiPrestasi;
using PROJECT_PRG2.CRUD_Tendik;
using PROJECT_PRG2.Laporan;
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
                if (panelLaporan.Height < 122)
                {
                    panelLaporan.Height += step;
                    if (panelLaporan.Height >= 122)
                    {
                        panelLaporan.Height = 122;
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

        private void btnLaporanKRS_Click(object sender, EventArgs e)
        {
            LaporanKRS  laporanKRS = new LaporanKRS();
            laporanKRS.TopLevel = false;
            laporanKRS.AutoScroll = true;
            panelMain.Controls.Add(laporanKRS);
            laporanKRS.Show();
        }

        private void btnLaporanKRPP_Click(object sender, EventArgs e)
        {
            LaporanKRPP laporanKRPP = new LaporanKRPP();
            laporanKRPP.TopLevel = false;
            laporanKRPP.AutoScroll = true;
            panelMain.Controls.Add(laporanKRPP);
            laporanKRPP.Show();
        }

        private void btnMabres_Click(object sender, EventArgs e)
        {
            LaporanKRS_KRPP laporanKRS_KRPP = new LaporanKRS_KRPP();
            laporanKRS_KRPP.TopLevel = false;
            laporanKRS_KRPP.AutoScroll = true ;
            panelMain.Controls.Add (laporanKRS_KRPP);
            laporanKRS_KRPP .Show();
        }
    }
}
