using PROJECT_PRG2.CRUD_Dosen;
using PROJECT_PRG2.CRUD_JenisPrestasi;
using PROJECT_PRG2.CRUD_Mahasiswa;
using PROJECT_PRG2.CRUD_MataKuliah;
using PROJECT_PRG2.CRUD_Pengumuman;
using PROJECT_PRG2.CRUD_PosisiPrestasi;
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

        public void btnProdi_Click(object sender, EventArgs e)
        {

            // Buat instance form UpDelet_Prodi
            UpDelet_Prodi upDeletProdiForm = new UpDelet_Prodi();

            // Atur parent form UpDelet_Prodi ke panelMain
            upDeletProdiForm.TopLevel = false;
            upDeletProdiForm.AutoScroll = true;
            panelMain.Controls.Add(upDeletProdiForm);
            upDeletProdiForm.Show();
/*
            UpDelet_Prodi upDelet_Prodi = new UpDelet_Prodi();
            upDelet_Prodi.Show();
            this.Hide();*/
        }
        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            // Buat instance form UpDelete_Mahasiswa
            UpDeletMahasiswa upDeletMahasiswa = new UpDeletMahasiswa();
            // Atur parent form UpDelet_Prodi ke panelMain
            upDeletMahasiswa.TopLevel = false;
            upDeletMahasiswa.AutoScroll = true;
            panelMain.Controls.Add(upDeletMahasiswa);
            upDeletMahasiswa.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnDosen_Click(object sender, EventArgs e)
        {
            // Buat instance form UDJenisPrestasi
            ViewDosen viewDosen = new ViewDosen();
            // Atur parent form UpDelet_Prodi ke panelMain
            viewDosen.TopLevel = false;
            viewDosen.AutoScroll = true;
            panelMain.Controls.Add(viewDosen);
            viewDosen.Show();
        }

        private void btnJenisPrestasi_Click(object sender, EventArgs e)
        {
            // Buat instance form UDJenisPrestasi
            UDJepres udJepres = new UDJepres();
            // Atur parent form UpDelet_Prodi ke panelMain
            udJepres.TopLevel = false;
            udJepres.AutoScroll = true;
            panelMain.Controls.Add(udJepres);
            udJepres.Show();
        }

        private void btnPosisiPrestasi_Click(object sender, EventArgs e)
        {
            // Buat instance form UDPosisPrestasi
            UDPospres udPospres = new UDPospres();
            // Atur parent form UpDelet_Prodi ke panelMain
            udPospres.TopLevel = false;
            udPospres.AutoScroll = true;
            panelMain.Controls.Add(udPospres);
            udPospres.Show();
        }

        private void btnMatakuliah_Click(object sender, EventArgs e)
        {
            ViewMatkul viewMatkul = new ViewMatkul();
            // Atur parent form UpDelet_Prodi ke panelMain
            viewMatkul.TopLevel = false;
            viewMatkul.AutoScroll = true;
            panelMain.Controls.Add(viewMatkul);
            viewMatkul.Show();
        }

        private void btnPengumuman_Click(object sender, EventArgs e)
        {
            UpdatePengumuman updatePengumuman = new UpdatePengumuman();
            // Atur parent form UpDelet_Prodi ke panelMain
            updatePengumuman.TopLevel = false;
            updatePengumuman.AutoScroll = true;
            panelMain.Controls.Add(updatePengumuman);
            updatePengumuman.Show();
        }

        private void btnTrsKRS_Click(object sender, EventArgs e)
        {
            trsKRS trsKRS = new trsKRS();
            // Atur parent form UpDelet_Prodi ke panelMain
            trsKRS.TopLevel = false;
            trsKRS.AutoScroll = true;
            panelMain.Controls.Add(trsKRS);
            trsKRS.Show();
        }
    }
}
