using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PROJECT_PRG2.CRUD_Prodi;

namespace PROJECT_PRG2.CRUD_Dosen
{
    public partial class ViewDosen : Form
    {
        private bool panelDataMuncul = false;
        private bool panelTransaksiMuncul = false;
        private bool panelLaporanMuncul = false;
        private int step = 10;

        public ViewDosen()
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

        private void ViewDosen_Load(object sender, EventArgs e)
        {
            // Load data into the 'fINDSMART.Dosen' table.
            this.dosenTableAdapter.Fill(this.fINDSMART.Dosen);

            // Ensure the Guna2DataGridView scrollbars are set correctly
            this.dgvDosen.ScrollBars = ScrollBars.Both;

            // Ensure AutoSizeColumnsMode is set
            this.dgvDosen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ensure some columns exceed the width of the DataGridView
            foreach (DataGridViewColumn column in dgvDosen.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                column.Width = 200; // Adjust this width as necessary
            }

            // Refresh the DataGridView to ensure scrollbars appear
            this.dgvDosen.Refresh();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            // Your code to display data in DataGridView
        }

        private void VScroll_Scroll(object sender, ScrollEventArgs e)
        {
            // Link the Guna2ScrollBar to the DataGridView
            this.dgvDosen.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void HScroll_Scroll(object sender, ScrollEventArgs e)
        {
            // Link the Guna2ScrollBar to the DataGridView
            this.dgvDosen.HorizontalScrollingOffset = e.NewValue;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DasboardTendik dasboardTendik = new DasboardTendik();
            dasboardTendik.Show();
            this.Hide();
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

        private void btnProdi_Click(object sender, EventArgs e)
        {
            UpDelet_Prodi upDelet_Prodi = new UpDelet_Prodi();
            upDelet_Prodi.Show();
            this.Hide();
        }
    }
}
