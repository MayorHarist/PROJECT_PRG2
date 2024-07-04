﻿using System;
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
        }

        private void AddTextBoxValidations()
        {
            txtPegawai.KeyPress += ValidateAlphanumeric;
            txtNIDN.KeyPress += ValidateNumeric;
            txtNama.KeyPress += ValidateAlphabetic;
            txtBidang.KeyPress += ValidateAlphabetic;
            txtPendidikan.KeyPress += ValidateAlphabetic;
            txtTelepon.KeyPress += ValidateNumeric;
        }

        private void ValidateAlphanumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya huruf dan angka yang diperbolehkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya angka yang diperbolehkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateAlphabetic(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya huruf yang diperbolehkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertDosen", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("No_Pegawai", txtPegawai.Text);
            insert.Parameters.AddWithValue("NIDN", txtNIDN.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Bidang_Kompetensi", txtBidang.Text);
            insert.Parameters.AddWithValue("Pendidikan_Terakhir", txtPendidikan.Text);
            insert.Parameters.AddWithValue("Tanggal_Lahir", DateTimeTanggal.Value);
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPerempuan.Checked ? "Perempuan" : string.Empty;
            insert.Parameters.AddWithValue("Jenis_Kelamin", jenisKelamin);
            insert.Parameters.AddWithValue("Alamat", txtAlamat.Text);
            insert.Parameters.AddWithValue("Email", txtEmail.Text);
            insert.Parameters.AddWithValue("Telepon", txtTelepon.Text);

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

        private void clear()
        {
            txtPegawai.Text = "";
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
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM Dosen";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;
                    string newID = "DOS" + count.ToString("000");

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
                MessageBox.Show("Semua field harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(txtTelepon.Text, @"^\d{10,15}$"))
            {
                MessageBox.Show("Format nomor telepon tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DateTimeTanggal.Value > DateTime.Now)
            {
                MessageBox.Show("Tanggal lahir tidak boleh lebih dari hari ini.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validasi lanjutan
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            try
            {
                connection.Open();

                SqlCommand checkNIDN = new SqlCommand("SELECT COUNT(*) FROM Dosen WHERE NIDN=@NIDN", connection);
                checkNIDN.Parameters.AddWithValue("@NIDN", txtNIDN.Text);

                int NIDNCount = (int)checkNIDN.ExecuteScalar();

                if (NIDNCount > 0)
                {
                    MessageBox.Show("NIDN sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                SqlCommand checkEmail = new SqlCommand("SELECT COUNT(*) FROM Dosen WHERE Email=@Email", connection);
                checkEmail.Parameters.AddWithValue("@Email", txtEmail.Text);

                int EmailCount = (int)checkEmail.ExecuteScalar();

                if (EmailCount > 0)
                {
                    MessageBox.Show("Email sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                SqlCommand checkTelepon = new SqlCommand("SELECT COUNT(*) FROM Dosen WHERE Telepon=@Telepon", connection);
                checkTelepon.Parameters.AddWithValue("@Telepon", txtTelepon.Text);

                int TeleponCount = (int)checkTelepon.ExecuteScalar();

                if (TeleponCount > 0)
                {
                    MessageBox.Show("Nomor telepon sudah ada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat validasi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
