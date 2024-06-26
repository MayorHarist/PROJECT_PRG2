using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Mahasiswa
{
    public partial class InputMahasiswa : Form
    {
        public InputMahasiswa()
        {
            InitializeComponent();
        }

        private void InputMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet6.ProgramStudi);

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi semua data harus diisi
            if (IsFormValid())
            {
                string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    SqlCommand insert = new SqlCommand("sp_InsertMahasiswa", connection);
                    insert.CommandType = CommandType.StoredProcedure;

                    insert.Parameters.AddWithValue("NIM", txtNIM.Text);
                    insert.Parameters.AddWithValue("Id_Prodi", cbProdi.SelectedValue);
                    insert.Parameters.AddWithValue("Nama", txtNama.Text);
                    insert.Parameters.AddWithValue("Tanggal_Lahir", DateTimeTanggal.Value);

                    // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
                    string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : "Perempuan";
                    insert.Parameters.AddWithValue("Jenis_Kelamin", jenisKelamin);
                    insert.Parameters.AddWithValue("Alamat", txtAlamat.Text);
                    insert.Parameters.AddWithValue("Email", txtEmail.Text);
                    insert.Parameters.AddWithValue("Telepon", txtTelepon.Text);
                    insert.Parameters.AddWithValue("Tahun_Masuk", txtTahunMasuk.Text);
                    insert.Parameters.AddWithValue("Username", txtUsername.Text);
                    insert.Parameters.AddWithValue("Password", txtPassword.Text);

                    try
                    {
                        connection.Open();
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to saved: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Semua data harus diisi dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsFormValid()
        {
            // Validasi untuk memastikan semua data telah diisi
            if (string.IsNullOrWhiteSpace(txtNIM.Text) ||
                cbProdi.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelepon.Text) ||
                string.IsNullOrWhiteSpace(txtTahunMasuk.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                return false;
            }

            // Validasi email menggunakan regular expression
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Format email tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi nomor telepon maksimal 13 digit
            if (txtTelepon.Text.Length > 13)
            {
                MessageBox.Show("Nomor telepon tidak boleh lebih dari 13 digit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Menggunakan regular expression untuk validasi email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void clear()
        {
            // Membersihkan TextBox dan kontrol lainnya
            txtNIM.Text = "";
            cbProdi.SelectedIndex = -1;
            txtNama.Text = "";
            DateTimeTanggal.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtTelepon.Text = "";
            txtTahunMasuk.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Menghentikan input karakter yang bukan angka
                MessageBox.Show("Nomor telepon hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
