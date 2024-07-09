using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.Transaksi
{
    public partial class KRPP : Form
    {
        string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART_MABRES";

        public KRPP()
        {
            InitializeComponent();
            AutoidKRPP();
            cbProdi.SelectedIndexChanged += new EventHandler(cbProdi_SelectedIndexChanged);
            ClearForm();

            // Set tglPengisian to the current date and disable it
            tglPengisian.Value = DateTime.Now;
            tglPengisian.Enabled = false;
        }

        public string AutoidKRPP()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM TransaksiPengajuanKRPP";

                // Execute count query
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;
                    string newID = "KRPP" + count.ToString("000");
                    txtIdKRPP.Text = newID;
                    return newID;
                }
            }
        }

        private void trsKRPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.PosisiPrestasi' table. You can move, or remove it, as needed.
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.PosisiPrestasi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.JenisPrestasi' table. You can move, or remove it, as needed.
            this.jenisPrestasiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.JenisPrestasi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.fINDSMART_MABRESDsAll.Mahasiswa);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMART_MABRESDsAll.TenagaKependidikan);
            // Mengaitkan event handler SelectedIndexChanged dengan cbJepres
            cbJepres.SelectedIndexChanged += new EventHandler(cbJepres_SelectedIndexChanged);

            // Set tglPengisian to the current date and disable it
            tglPengisian.Value = DateTime.Now;
            tglPengisian.Enabled = false;

            ClearForm();
        }

        private void cbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdi.SelectedValue != null)
            {
                string selectedProdi = cbProdi.SelectedValue.ToString();
                string query = "SELECT NIM, Nama FROM Mahasiswa WHERE Id_Prodi = @Id_Prodi";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id_Prodi", selectedProdi);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cbMahasiswa.DataSource = dt;
                        cbMahasiswa.DisplayMember = "Nama";
                        cbMahasiswa.ValueMember = "NIM";
                    }
                }
            }
        }

        private void ClearForm()
        {
            // Kosongkan semua TextBox
            txtnamaPrestasi.Text = string.Empty;
            txtUraian.Text = string.Empty;
            txtLembagaPelaksana.Text = string.Empty;
            txtPoint.Text = string.Empty;

            // Set semua ComboBox ke default (tidak terpilih)
            cbMahasiswa.SelectedIndex = -1;
            cbTendik.SelectedIndex = -1;
            cbJepres.SelectedIndex = -1;
            cbPospres.SelectedIndex = -1;
            cbProdi.SelectedIndex = -1;

            // Set DateTimePicker ke nilai default (sebagai contoh: tanggal sekarang)
            //tglPrestasi.Value = DateTime.Now;
            tglPengisian.Value = DateTime.Now;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi masukan pengguna dalam variabel
            string idTransKRPP = txtIdKRPP.Text;
            string namaPrestasi = txtnamaPrestasi.Text;
            string uraianSingkat = txtUraian.Text;
            string lembagaPelaksana = txtLembagaPelaksana.Text;
            DateTime tanggalPrestasi = tglPrestasi.Value;
            DateTime tanggalPengisian = tglPengisian.Value;
            string pointText = txtPoint.Text;

            if (string.IsNullOrEmpty(idTransKRPP) || string.IsNullOrEmpty(namaPrestasi) ||
                string.IsNullOrEmpty(uraianSingkat) || string.IsNullOrEmpty(lembagaPelaksana) ||
                string.IsNullOrEmpty(pointText) || cbMahasiswa.SelectedValue == null ||
                cbTendik.SelectedValue == null || cbJepres.SelectedValue == null ||
                cbPospres.SelectedValue == null || cbProdi.SelectedValue == null)
            {
                // Tampilkan pesan kesalahan
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan eksekusi jika ada input yang kosong
            }

            if (!int.TryParse(pointText, out int point))
            {
                MessageBox.Show("Masukkan nilai numerik yang valid untuk Point", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tampilkan data yang telah diinputkan untuk konfirmasi
            string message = $"Apakah data berikut sudah benar?\n\n" +
                             $"ID Trans KRPP: {idTransKRPP}\n" +
                             $"Nama Prestasi: {namaPrestasi}\n" +
                             $"Uraian Singkat: {uraianSingkat}\n" +
                             $"Lembaga Pelaksana: {lembagaPelaksana}\n" +
                             $"Tanggal Prestasi: {tanggalPrestasi.ToShortDateString()}\n" +
                             $"Tanggal Pengisian: {tanggalPengisian.ToShortDateString()}\n" +
                             $"Point: {point}\n" +
                             $"NIM: {cbMahasiswa.SelectedValue}\n" +
                             $"Tenaga Kependidikan: {cbTendik.SelectedValue}\n" +
                             $"Jenis Prestasi: {cbJepres.SelectedValue}\n" +
                             $"Posisi Prestasi: {cbPospres.SelectedValue}\n" +
                             $"Program Studi: {cbProdi.SelectedValue}\n";

            DialogResult result = MessageBox.Show(message, "Konfirmasi Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna menekan 'No', hentikan proses submit
            }

            // Simpan data ke database
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_InsertKRPP", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_TransKRPP", idTransKRPP);
            insert.Parameters.AddWithValue("Nama_Prestasi", namaPrestasi);
            insert.Parameters.AddWithValue("Uraian_Singkat", uraianSingkat);
            insert.Parameters.AddWithValue("Lembaga_Pelaksana", lembagaPelaksana);
            insert.Parameters.AddWithValue("Tanggal_Prestasi", tanggalPrestasi);
            insert.Parameters.AddWithValue("Tanggal_Pengisian", tanggalPengisian);
            insert.Parameters.AddWithValue("Point", point);
            insert.Parameters.AddWithValue("NIM", cbMahasiswa.SelectedValue);
            insert.Parameters.AddWithValue("Id_TKN", cbTendik.SelectedValue);
            insert.Parameters.AddWithValue("Id_JenisPrestasi", cbJepres.SelectedValue);
            insert.Parameters.AddWithValue("Id_PosisiPrestasi", cbPospres.SelectedValue);
            insert.Parameters.AddWithValue("Id_Prodi", cbProdi.SelectedValue);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                AutoidKRPP();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal untuk disimpan: " + ex.Message);
            }
        }

        private void cbJepres_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ambil nilai Point dari JenisPrestasi yang dipilih
            if (cbJepres.SelectedValue != null)
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                string query = "SELECT Point FROM JenisPrestasi WHERE Id_JenisPrestasi = @Id_JenisPrestasi";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id_JenisPrestasi", cbJepres.SelectedValue.ToString());

                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtPoint.Text = result.ToString();
                        }
                        else
                        {
                            txtPoint.Text = "";
                        }
                    }
                }
            }
        }


        private void clear()
        {
            //txtIdKRPP.Text = "";
            txtnamaPrestasi.Text = "";
            txtLembagaPelaksana.Text = "";
            txtPoint.Text = "";
            txtUraian.Text = "";
            cbTendik.Text = "";
            cbProdi.Text = "";
            cbPospres.Text = "";
            cbMahasiswa.Text = "";
            cbJepres.Text = "";
            tglPengisian.Text = "";
            tglPrestasi.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtIdKRPP_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Jika tombol yang ditekan adalah backspace atau delete
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true; // Membatalkan aksi penghapusan
                MessageBox.Show("Id sudah dibuat otomatis", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol yang ditekan adalah backspace atau delete
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true; // Membatalkan aksi penghapusan
                MessageBox.Show("Point ada secara otomatis saat jenis prestasi telah dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtnamaPrestasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nama tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
