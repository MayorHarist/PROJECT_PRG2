using PROJECT_PRG2.CRUD_Dosen;
using PROJECT_PRG2.CRUD_JenisPrestasi;
using PROJECT_PRG2.CRUD_Mahasiswa;
using PROJECT_PRG2.CRUD_MataKuliah;
using PROJECT_PRG2.CRUD_Pengumuman;
using PROJECT_PRG2.CRUD_PosisiPrestasi;
using PROJECT_PRG2.CRUD_Prodi;
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

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
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

        private void ShowFormInPanel(Form form)
        {
            // Cek apakah form sudah ada di panel
            Form existingForm = panelMain.Controls.OfType<Form>().FirstOrDefault(f => f.GetType() == form.GetType());

            if (existingForm != null)
            {
                // Jika form sudah ada, bawa ke depan
                existingForm.BringToFront();
            }
            else
            {
                // Jika form belum ada, tambahkan ke panel
                form.TopLevel = false;
                form.AutoScroll = true;
                panelMain.Controls.Add(form);
                form.Show();
            }
        }

        private void btnProdi_Click(object sender, EventArgs e)
        {
            UpDelet_Prodi upDeletProdiForm = new UpDelet_Prodi();
            ShowFormInPanel(upDeletProdiForm);
        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            UpDeletMahasiswa upDeletMahasiswaForm = new UpDeletMahasiswa();
            ShowFormInPanel(upDeletMahasiswaForm);
        }

        private void btnDosen_Click(object sender, EventArgs e)
        {
            ViewDosen viewDosenForm = new ViewDosen();
            ShowFormInPanel(viewDosenForm);
        }

        private void btnJenisPrestasi_Click(object sender, EventArgs e)
        {
            UDJepres udJepresForm = new UDJepres();
            ShowFormInPanel(udJepresForm);
        }

        private void btnPosisiPrestasi_Click(object sender, EventArgs e)
        {
            UDPospres udPospresForm = new UDPospres();
            ShowFormInPanel(udPospresForm);
        }

        private void btnMatakuliah_Click(object sender, EventArgs e)
        {
            ViewMatkul viewMatkulForm = new ViewMatkul();
            ShowFormInPanel(viewMatkulForm);
        }

        private void btnPengumuman_Click(object sender, EventArgs e)
        {
            UpdatePengumuman updatePengumumanForm = new UpdatePengumuman();
            ShowFormInPanel(updatePengumumanForm);
        }

        private void btnTrsKRS_Click(object sender, EventArgs e)
        {
            trsKRS trsKRSForm = new trsKRS();
            ShowFormInPanel(trsKRSForm);
        }

        private void btnTrsKRPP_Click(object sender, EventArgs e)
        {
            trsKRPP trsKRPPForm = new trsKRPP();
            ShowFormInPanel(trsKRPPForm);
        }

        private void btnLaporanKRS_Click(object sender, EventArgs e)
        {
            LaporanKRS laporanKRSForm = new LaporanKRS();
            ShowFormInPanel(laporanKRSForm);
        }

        private void btnLaporanKRPP_Click(object sender, EventArgs e)
        {
            LaporanKRPP laporanKRPPForm = new LaporanKRPP();
            ShowFormInPanel(laporanKRPPForm);
        }

        private void btnMabres_Click(object sender, EventArgs e)
        {
            LaporanKRS_KRPP laporanKRS_KRPPForm = new LaporanKRS_KRPP();
            ShowFormInPanel(laporanKRS_KRPPForm);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
