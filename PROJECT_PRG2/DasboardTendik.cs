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
    public partial class DasboardTendik : Form
    {
        private bool panelDataMuncul = false;
        private bool panelTransaksiMuncul = false;
        private bool panelLaporanMuncul = false;
        private int step = 10;

        public DasboardTendik()
        {
            InitializeComponent();
            panelData.Height = 0;
            panelTransaksi.Height = 0;
            panelLaporan.Height = 0;
            timerData.Interval = 10;
            timerData.Tick += timerData_Tick;
            timerTRS.Interval = 10;
            timerTRS.Tick += timerTRS_Tick;
            timerLaporan.Interval = 10;
            timerLaporan.Tick += timerLaporan_Tick;
        }

        private void timerData_Tick(object sender, EventArgs e)
        {
            if (panelDataMuncul)
            {
                if (panelData.Height < 290)
                {
                    panelData.Height += step;
                    if (panelData.Height >= 290)
                    {
                        panelData.Height = 290;
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

        private void btnData_Click(object sender, EventArgs e)
        {
            panelDataMuncul = !panelDataMuncul;
            timerData.Start();
        }

        private void timerTRS_Tick(object sender, EventArgs e)
        {
            if (panelTransaksiMuncul)
            {
                if (panelTransaksi.Height < 103)
                {
                    panelTransaksi.Height += step;
                    if (panelTransaksi.Height >= 103)
                    {
                        panelTransaksi.Height = 103;
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

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            panelTransaksiMuncul = !panelTransaksiMuncul;
            timerTRS.Start();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            panelLaporanMuncul = !panelLaporanMuncul;
            timerLaporan.Start();
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
    }
}
