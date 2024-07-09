using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_PRG2.CRUD_Dosen
{
    public partial class InputDosen : Form
    {
        public InputDosen()
        {
            InitializeComponent();
            autoid();
            AddTextBoxValidations();
            DateTimeTanggal.ValueChanged += DateTimeTanggal_ValueChanged; 
        }

        private void AddTextBoxValidations()
        {
            txtPegawai.KeyPress += ValidateAlphanumeric;
            txtNIDN.KeyPress += ValidateNumeric;
            txtNama.KeyPress += ValidateAlphabetic;
            txtTelepon.KeyPress += ValidateNumeric;
        }

        private void ValidateAlphanumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya huruf dan angka yang diperbolehkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya angka yang diperbolehkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidateAlphabetic(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya huruf yang diperbolehkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DateTimeTanggal_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimeTanggal.Value > DateTime.Now)
            {
                MessageBox.Show("Tanggal lahir tidak boleh lebih dari hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateTimeTanggal.Value = DateTime.Now; // Set nilai kembali ke tanggal hari ini
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            string noPegawai = txtPegawai.Text;
            string nidn = txtNIDN.Text;
            string nama = txtNama.Text;
            string bidang = txtBidang.Text;
            string pendidikan = txtPendidikan.Text;
            DateTime tanggalLahir = DateTimeTanggal.Value;
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPerempuan.Checked ? "Perempuan" : string.Empty;
            string alamat = txtAlamat.Text;
            string email = txtEmail.Text;
            string telepon = txtTelepon.Text;

            string message = $"Apakah Anda yakin ingin menyimpan data berikut?\n\n" +
                             $"No Pegawai: {noPegawai}\n" +
                             $"NIDN: {nidn}\n" +
                             $"Nama: {nama}\n" +
                             $"Bidang Kompetensi: {bidang}\n" +
                             $"Pendidikan Terakhir: {pendidikan}\n" +
                             $"Tanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                             $"Jenis Kelamin: {jenisKelamin}\n" +
                             $"Alamat: {alamat}\n" +
                             $"Email: {email}\n" +
                             $"Telepon: {telepon}";

            DialogResult result = MessageBox.Show(message, "Konfirmasi Simpan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand insert = new SqlCommand("sp_InsertDosen", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("No_Pegawai", noPegawai);
                insert.Parameters.AddWithValue("NIDN", nidn);
                insert.Parameters.AddWithValue("Nama", nama);
                insert.Parameters.AddWithValue("Bidang_Kompetensi", bidang);
                insert.Parameters.AddWithValue("Pendidikan_Terakhir", pendidikan);
                insert.Parameters.AddWithValue("Tanggal_Lahir", tanggalLahir);
                insert.Parameters.AddWithValue("Jenis_Kelamin", jenisKelamin);
                insert.Parameters.AddWithValue("Alamat", alamat);
                insert.Parameters.AddWithValue("Email", email);
                insert.Parameters.AddWithValue("Telepon", telepon);

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tidak dapat menyimpan: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Penyimpanan data dibatalkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clear()
        {
            txtNIDN.Text = "";
            txtNama.Text = "";
            txtBidang.Text = "";
            txtPendidikan.Text = "";
            DateTimeTanggal.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtTelepon.Text = "";
        }

        public string autoid()
        {
            string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART_MABRES";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string functionQuery = "SELECT dbo.autoIdDosen()";

                using (SqlCommand functionCommand = new SqlCommand(functionQuery, connection))
                {
                    string newID = functionCommand.ExecuteScalar().ToString();
                    txtPegawai.Text = newID;
                    return newID;
                }
            }
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool ValidateForm()
        {
            // Validasi dasar
            if (string.IsNullOrEmpty(txtPegawai.Text) ||
                string.IsNullOrEmpty(txtNIDN.Text) ||
                string.IsNullOrEmpty(txtNama.Text) ||
                string.IsNullOrEmpty(txtBidang.Text) ||
                string.IsNullOrEmpty(txtPendidikan.Text) ||
                string.IsNullOrEmpty(txtAlamat.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelepon.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtTelepon.Text, @"^\d{10,15}$"))
            {
                MessageBox.Show("Format nomor telepon tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi lanjutan
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlCommand checkNIDN = new SqlCommand("SELECT COUNT(*) FROM Dosen WHERE NIDN=@NIDN", connection);
                checkNIDN.Parameters.AddWithValue("@NIDN", txtNIDN.Text);

                int NIDNCount = (int)checkNIDN.ExecuteScalar();

                if (NIDNCount > 0)
                {
                    MessageBox.Show("NIDN sudah ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SqlCommand checkEmail = new SqlCommand("SELECT COUNT(*) FROM Dosen WHERE Email=@Email", connection);
                checkEmail.Parameters.AddWithValue("@Email", txtEmail.Text);

                int EmailCount = (int)checkEmail.ExecuteScalar();

                if (EmailCount > 0)
                {
                    MessageBox.Show("Email sudah ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                SqlCommand checkTelepon = new SqlCommand("SELECT COUNT(*) FROM Dosen WHERE Telepon=@Telepon", connection);
                checkTelepon.Parameters.AddWithValue("@Telepon", txtTelepon.Text);

                int TeleponCount = (int)checkTelepon.ExecuteScalar();

                if (TeleponCount > 0)
                {
                    MessageBox.Show("Nomor telepon sudah ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat validasi: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
    }
}
