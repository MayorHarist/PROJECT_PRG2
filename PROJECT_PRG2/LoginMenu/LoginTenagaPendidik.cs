using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace PROJECT_PRG2
{
    public partial class LoginSbgTenDik : Form
    {
        private string connectionString = "integrated security=true; data source =.; initial catalog=FINDSMART";

        public LoginSbgTenDik()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtSandi.Text;


            // SQL Query untuk memverifikasi username dan password
            string query = "SELECT COUNT(1) FROM TenagaKependidikan WHERE Username=@Username AND Password=@Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Tambahkan parameter untuk query
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        // Buka koneksi ke database
                        conn.Open();

                        // Eksekusi query dan ambil hasil
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login berhasil!");
                            // Anda dapat membuka form baru di sini atau mengarahkan pengguna ke bagian lain dari aplikasi Anda
                            DasboardTendik dasboardTendik = new DasboardTendik();
                            dasboardTendik.Show();
                            this.Hide(); // Sembunyikan form login saat form kedua dibuka
                        }
                        else
                        {
                            MessageBox.Show("Nama Pengguna dan Kata Sandi salah.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSandi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
