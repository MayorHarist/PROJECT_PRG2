﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Mahasiswa
{
    public partial class UpDeletMahasiswa : Form
    {
        public UpDeletMahasiswa()
        {
            InitializeComponent();
        }

        private void UpDeletMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.fINDSMART_MABRESDataSet1.Mahasiswa);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Mahasiswa' table. You can move, or remove it, as needed.
            ///this.mahasiswaTableAdapter.Fill(this.fINDSMART_MABRESDsAll.Mahasiswa);

        }

        

        private void clear()
        {
            // Membersihkan TextBox
            txtCari.Clear();
            txtNIM.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtTahunMasuk.Clear();
            txtKelamin.Clear();
            //txtUsername.Clear();
            //txtPassword.Clear();

            // Reset ComboBox
            cbProdi.SelectedIndex = -1;  // Mengatur ulang ComboBox ke nilai default (tidak ada pilihan)

            // Mengatur ulang DateTimePicker ke tanggal saat ini
            DateTimeTanggal.Value = DateTime.Now;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DasboardTendik dasboardTendik = new DasboardTendik();
            dasboardTendik.Show();
            this.Hide();
        }

        private void btnTambahMhs_Click(object sender, EventArgs e)
        {
            InputMahasiswa inputMahasiswa = new InputMahasiswa();
            inputMahasiswa.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    /*if (EmailExists(txtEmail.Text, connection))
                    {
                        MessageBox.Show("Email sudah terdaftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }*/

                    SqlCommand update = new SqlCommand("sp_UpdateMahasiswa", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter sesuai dengan input dari form
                    update.Parameters.AddWithValue("@NIM", txtNIM.Text);

                    if (cbProdi.SelectedValue == null)
                    {
                        MessageBox.Show("Silakan pilih program studi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    update.Parameters.AddWithValue("@Id_Prodi", cbProdi.SelectedValue);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Tanggal_Lahir", DateTimeTanggal.Value);
                    update.Parameters.AddWithValue("@Jenis_Kelamin", txtKelamin.Text);
                    update.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                    update.Parameters.AddWithValue("@Email", txtEmail.Text);
                    update.Parameters.AddWithValue("@Telepon", txtTelepon.Text);
                    update.Parameters.AddWithValue("@Tahun_Masuk", txtTahunMasuk.Text);
                    //update.Parameters.AddWithValue("@Username", txtUsername.Text);
                    //update.Parameters.AddWithValue("@Password", txtPassword.Text);

                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
                    this.mahasiswaTableAdapter1.Fill(this.fINDSMART_MABRESDataSet1.Mahasiswa);

                    // Panggil metode clear() jika ingin membersihkan form setelah update
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus__Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand delete = new SqlCommand("DELETE FROM Mahasiswa WHERE NIM = @NIM", connection);
                    delete.Parameters.AddWithValue("@NIM", txtNIM.Text);

                    delete.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
                    //this.programStudiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
                    // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Mahasiswa' table. You can move, or remove it, as needed.
                    //this.mahasiswaTableAdapter.Fill(this.fINDSMART_MABRESDsAll.Mahasiswa);
                    // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
                    this.mahasiswaTableAdapter1.Fill(this.fINDSMART_MABRESDataSet1.Mahasiswa);
                    clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtNIM kosong
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Data ID harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("sp_CariMahasiswa", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@Cari", txtCari.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtNIM.Text = dataTable.Rows[0]["NIM"].ToString();
                        cbProdi.SelectedValue = dataTable.Rows[0]["Id_Prodi"];  // Gunakan SelectedValue
                        txtNama.Text = dataTable.Rows[0]["Nama"].ToString();

                        // Convert Tanggal_Lahir to DateTime
                        DateTime tanggalLahir;
                        if (DateTime.TryParse(dataTable.Rows[0]["Tanggal_Lahir"].ToString(), out tanggalLahir))
                        {
                            DateTimeTanggal.Value = tanggalLahir;
                        }

                        txtKelamin.Text = dataTable.Rows[0]["Jenis_Kelamin"].ToString();

                        txtAlamat.Text = dataTable.Rows[0]["Alamat"].ToString();
                        txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                        txtTelepon.Text = dataTable.Rows[0]["Telepon"].ToString();
                        txtTahunMasuk.Text = dataTable.Rows[0]["Tahun_Masuk"].ToString();
                        //txtUsername.Text = dataTable.Rows[0]["Username"].ToString();
                        //txtPassword.Text = dataTable.Rows[0]["Password"].ToString();

                        // Mengaktifkan kontrol jika data ditemukan
                    }
                    else
                    {
                        // Menampilkan pesan jika data tidak ditemukan
                        MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Menonaktifkan kontrol jika data tidak ditemukan
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Mahasiswa' table. You can move, or remove it, as needed.
            //this.mahasiswaTableAdapter.Fill(this.fINDSMART_MABRESDsAll.Mahasiswa;
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.fINDSMART_MABRESDataSet1.Mahasiswa);

            
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nama tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool EmailExists(string email, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Mahasiswa WHERE Email = @Email", connection);
            cmd.Parameters.AddWithValue("@Email", email);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private bool ValidateFields()
        {
            if (txtTelepon.Text.Length > 13)
            {
                MessageBox.Show("Nomor telepon tidak boleh lebih dari 13 digit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
