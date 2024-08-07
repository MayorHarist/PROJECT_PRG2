﻿using System;
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
        private string connectionString = "integrated security=true; data source =.; initial catalog=FINDSMART_MABRES";
        
        public static string LoggedInId { get; private set; }
        public LoginSbgTenDik()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Ambil input dari pengguna
            string username = txtUsername.Text.Trim();
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

            // SQL Query untuk memverifikasi username dan password
            string query = "SELECT Id_TKN FROM TenagaKependidikan WHERE Username=@Username AND Password=@Password";

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
                        object result = cmd.ExecuteScalar();

                        if (result != null) // Jika hasil tidak null
                        {
                            LoggedInId = result.ToString(); // Simpan ID TenagaPendidikan yang login

                            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Buka form baru atau pindah ke bagian lain dari aplikasi
                            DasboardTendik dashboardTendik = new DasboardTendik();
                            dashboardTendik.Show();
                            this.Hide(); // Sembunyikan form login saat form kedua dibuka
                        }
                        else
                        {
                            MessageBox.Show("Nama Pengguna dan Kata Sandi salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
