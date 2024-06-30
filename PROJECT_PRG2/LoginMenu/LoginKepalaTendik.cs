using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.LoginMenu
{
    public partial class LoginKepalaTendik : Form
    {
        public LoginKepalaTendik()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Tentukan username dan password yang valid
            string validUsername = "Kepalatendik";
            string validPassword = "Kepalatendik";

            // Ambil input dari pengguna
            string username = txtUsername.Text.Trim(); // Trim untuk menghapus spasi di awal dan akhir
            string password = txtSandi.Text.Trim();

            // Validasi input kosong
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nama pengguna tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kata sandi tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi panjang input (misal, maksimum 50 karakter)
            if (username.Length > 50)
            {
                MessageBox.Show("Nama pengguna terlalu panjang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length > 50)
            {
                MessageBox.Show("Kata sandi terlalu panjang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifikasi username dan password
            if (username == validUsername && password == validPassword)
            {
                MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Anda dapat membuka form baru di sini atau mengarahkan pengguna ke bagian lain dari aplikasi Anda
                Dashboard_KepalaTendik dashboard_KepalaTendik = new Dashboard_KepalaTendik();
                dashboard_KepalaTendik.Show();
                this.Hide(); // Sembunyikan form login saat form kedua dibuka
            }
            else
            {
                MessageBox.Show("Nama Pengguna dan Kata Sandi salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSandi_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginKepalaTendik_Load(object sender, EventArgs e)
        {

        }
    }
}
