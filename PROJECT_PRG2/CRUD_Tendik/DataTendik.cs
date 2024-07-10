using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Tendik
{
    public partial class DataTendik : Form
    {
        public DataTendik()
        {
            InitializeComponent();
            autoid();
        }

        private void DataTendik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.TenagaKependidikan' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'tendik.TenagaKependidikan' table. You can move, or remove it, as needed.
            //karna tadinya ada tabel view gitu... di inputnya
        }

        private void btnTambahTendik_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            SqlConnection connection = new SqlConnection(connectionString);

            // Validasi email menggunakan regex
            if (!IsValidEmail(txtEmailTendik.Text))
            {
                MessageBox.Show("Format email tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Menghentikan proses penyimpanan data jika email tidak valid
            }

            //Create Requred Validator untuk verifikasi masukan pengguna wajib diisi,
            //dengan memeriksa apakah semua data terisi atau belum
            if (string.IsNullOrWhiteSpace(txtIDTendik.Text) || string.IsNullOrWhiteSpace(txtNamaTendik.Text) || string.IsNullOrWhiteSpace(txtAlmatTendik.Text) ||
                string.IsNullOrWhiteSpace(txtEmailTendik.Text) || string.IsNullOrWhiteSpace(TelpTendik.Text) || string.IsNullOrWhiteSpace(userNmTendik.Text) ||
                string.IsNullOrWhiteSpace(txtPassTendik.Text))
            {
                MessageBox.Show("Seluruh Data wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Memastikan apakah data yang akan diismpan sudah benar, jika belum maka masih bisa mengisi ulang sebelum simpan
            string message = $"Apakah data berikut sudah benar?\n\n" +
                            $"ID TKN: {txtIDTendik.Text}\n" +
                            $"Nama: {txtNamaTendik.Text}\n" +
                            $"Tanggal_Lahir: {tglLahirTendik.Value}\n" +
                            $"Jenis_Kelamin: {(rbLaki.Checked ? "Laki-Laki" : rbPuan.Checked ? "Perempuan" : "Belum dipilih")}\n" +
                            $"Alamat: {txtAlmatTendik.Text}\n" +
                            $"Email: {txtEmailTendik.Text}\n" +
                            $"Telepon: {TelpTendik.Text}\n" +
                            $"Username: {userNmTendik.Text}\n" +
                            $"Password: {txtPassTendik.Text}\n";

            DialogResult result = MessageBox.Show(message, "Konfirmasi Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna menekan 'No', hentikan proses submit
            }

            // Check if email already exists in database
            using (SqlConnection connectionCheck = new SqlConnection(connectionString))
            {
                connectionCheck.Open();
                string query = "SELECT COUNT(*) FROM TenagaKependidikan WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connectionCheck);
                command.Parameters.AddWithValue("@Email", txtEmailTendik.Text);
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Email sudah ada di database. Silakan gunakan alamat email yang berbeda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            SqlCommand insert = new SqlCommand("sp_InsertTendik", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
            insert.Parameters.AddWithValue("@Nama", txtNamaTendik.Text);
            insert.Parameters.AddWithValue("@Tanggal_Lahir", tglLahirTendik.Value);
            // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPuan.Checked ? "Perempuan" : string.Empty;
            insert.Parameters.AddWithValue("@Jenis_Kelamin", jenisKelamin);
            insert.Parameters.AddWithValue("@Alamat", txtAlmatTendik.Text);
            insert.Parameters.AddWithValue("@Email", txtEmailTendik.Text);
            insert.Parameters.AddWithValue("@Telepon", TelpTendik.Text);
            insert.Parameters.AddWithValue("@Username", userNmTendik.Text);
            insert.Parameters.AddWithValue("@Password", txtPassTendik.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                autoid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }
        }
        private bool IsValidEmail(string email)
        {
            // Pattern regex untuk validasi email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            // Mengecek apakah email cocok dengan pattern regex
            return Regex.IsMatch(email, pattern);
        }
        private void clear()
        {
            txtNamaTendik.Text = "";
            tglLahirTendik.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPuan.Checked = false;
            txtAlmatTendik.Text = "";
            txtEmailTendik.Text = "";
            TelpTendik.Text = "";
            userNmTendik.Text = "";
            txtPassTendik.Text = "";
        }

        public string autoid()
        {
            //string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string functionQuery = "SELECT dbo.autoIdTendik()";

                using (SqlCommand functionCommand = new SqlCommand(functionQuery, connection))
                {
                    string newID = functionCommand.ExecuteScalar().ToString();
                    txtIDTendik.Text = newID;
                    return newID;
                }
            }
        }

        private void btnBatalTendik_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNamaTendik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nama tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TelpTendik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Masukkan hanya berupa Angka !");
            }

            if (TelpTendik.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nomor telepon tidak boleh lebih dari 13 digit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
