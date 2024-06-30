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
            string connectionstring = "integrated security=true; data source=.; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

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
            //Memastikan apakah data yang akan diismpan sudah benar, jika belum maka masih bisa mengisi ulang sebelum simpan
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
            txtIDTendik.Text = "";
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
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01 ; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM TenagaKependidikan";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "TKN" + count.ToString("000");

                    txtIDTendik.Text = newID;
                    return newID;
                }
            }
        }

        private void btnBatalTendik_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void btnTampilTendik_Click(object sender, EventArgs e)
        {
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet6.TenagaKependidikan);
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void txtNamaTendik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Masukkan hanya berupa huruf!");
            }
        }
        private void TelpTendik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Masukkan hanya berupa Angka !");
            }
        }


































        private void tenagaKependidikanBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tenagaKependidikanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvTendik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
