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
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.fINDSMARTDataSet7.Mahasiswa);
            

            // Set default state of controls
            SetControlsEnabled(false);
        }

        private void SetControlsEnabled(bool enabled)
        {
            cbProdi.Enabled = enabled;
            txtNama.Enabled = enabled;
            DateTimeTanggal.Enabled = enabled;
            rbLaki.Enabled = enabled;
            rbPerempuan.Enabled = enabled;
            txtAlamat.Enabled = enabled;
            txtEmail.Enabled = enabled;
            txtTelepon.Enabled = enabled;
            txtTahunMasuk.Enabled = enabled;
            txtUsername.Enabled = enabled;
            txtPassword.Enabled = enabled;

            btnUbah.Enabled = enabled;
            btnHapus.Enabled = enabled;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

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
                    update.Parameters.AddWithValue("@Jenis_Kelamin", rbLaki.Checked ? "Laki-laki" : "Perempuan");
                    update.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                    update.Parameters.AddWithValue("@Email", txtEmail.Text);
                    update.Parameters.AddWithValue("@Telepon", txtTelepon.Text);
                    update.Parameters.AddWithValue("@Tahun_Masuk", txtTahunMasuk.Text);
                    update.Parameters.AddWithValue("@Username", txtUsername.Text);
                    update.Parameters.AddWithValue("@Password", txtPassword.Text);

                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Memperbarui data di tampilan (jika ada)
                    this.mahasiswaTableAdapter.Fill(this.fINDSMARTDataSet7.Mahasiswa);
                    // Panggil metode clear() jika ingin membersihkan form setelah update
                    clear();
                    SetControlsEnabled(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            // Membersihkan TextBox
            txtNIM.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtTahunMasuk.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

            // Reset ComboBox
            cbProdi.SelectedIndex = -1;  // Mengatur ulang ComboBox ke nilai default (tidak ada pilihan)

            // Mengatur ulang DateTimePicker ke tanggal saat ini
            DateTimeTanggal.Value = DateTime.Now;

            // Reset RadioButton
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtNIM kosong
                if (string.IsNullOrWhiteSpace(txtNIM.Text))
                {
                    MessageBox.Show("Data ID harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM Mahasiswa WHERE NIM=@NIM", connection);
                    myCommand.Parameters.AddWithValue("@NIM", txtNIM.Text);
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

                        string jenisKelamin = dataTable.Rows[0]["Jenis_Kelamin"].ToString();
                        if (jenisKelamin == "Laki-laki")
                        {
                            rbLaki.Checked = true;
                        }
                        else if (jenisKelamin == "Perempuan")
                        {
                            rbPerempuan.Checked = true;
                        }
                        else
                        {
                            rbLaki.Checked = false;
                            rbPerempuan.Checked = false;
                        }
                        txtAlamat.Text = dataTable.Rows[0]["Alamat"].ToString();
                        txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                        txtTelepon.Text = dataTable.Rows[0]["Telepon"].ToString();
                        txtTahunMasuk.Text = dataTable.Rows[0]["Tahun_Masuk"].ToString();
                        txtUsername.Text = dataTable.Rows[0]["Username"].ToString();
                        txtPassword.Text = dataTable.Rows[0]["Password"].ToString();

                        // Mengaktifkan kontrol jika data ditemukan
                        SetControlsEnabled(true);
                    }
                    else
                    {
                        // Menampilkan pesan jika data tidak ditemukan
                        MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Menonaktifkan kontrol jika data tidak ditemukan
                        SetControlsEnabled(false);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand delete = new SqlCommand("sp_DeleteMahasiswa", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("@NIM", txtNIM.Text);

                    delete.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mahasiswaTableAdapter.Fill(this.fINDSMARTDataSet7.Mahasiswa);
                    clear();
                    SetControlsEnabled(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputMahasiswa inputMahasiswa = new InputMahasiswa();
            inputMahasiswa.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DasboardTendik dasboardTendik = new DasboardTendik();  
            dasboardTendik.Show();
            this.Hide();
        }
    }
}
