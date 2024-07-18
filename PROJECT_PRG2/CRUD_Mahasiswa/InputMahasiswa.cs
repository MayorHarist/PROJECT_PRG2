using PROJECT_PRG2.CRUD_Prodi;
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
            autoid();
        }

        private void InputMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Mahasiswa' table. You can move, or remove it, as needed.
            //this.mahasiswaTableAdapter.Fill(this.fINDSMART_MABRESDsAll.Mahasiswa);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi semua data harus diisi
            if (IsFormValid())
            {
                // Validasi umur tidak boleh kurang dari 21 tahun
                DateTime today = DateTime.Today;
                DateTime birthDate = DateTimeTanggal.Value;
                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age)) age--;

                if (age < 18)
                {
                    MessageBox.Show("Umur tidak boleh kurang dari 18 tahun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Menghentikan proses penyimpanan data jika umur kurang dari 21 tahun
                }

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                    //insert.Parameters.AddWithValue("Username", txtUsername.Text);
                    //insert.Parameters.AddWithValue("Password", txtPassword.Text);

                    try
                    {
                        connection.Open();
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to save: " + ex.Message);
                    }
                    autoid();
                }
            }
            else
            {
                MessageBox.Show("Semua data harus diisi dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string autoid()
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string functionQuery = "SELECT dbo.autoIdMahasiswa()";

                using (SqlCommand command = new SqlCommand(functionQuery, connection))
                {
                    string newID = command.ExecuteScalar().ToString();

                    txtNIM.Text = newID;
                    return newID;
                }
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
                string.IsNullOrWhiteSpace(txtTahunMasuk.Text))
            //string.IsNullOrWhiteSpace(txtUsername.Text) ||
            //string.IsNullOrWhiteSpace(txtPassword.Text))
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

            // Validasi apakah email sudah ada dalam database
            if (!IsEmailUnique(txtEmail.Text))
            {
                MessageBox.Show("Email sudah ada dalam database.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool IsEmailUnique(string email)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Mahasiswa WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0;
                }
            }
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
            //txtUsername.Text = "";
            //txtPassword.Text = "";
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
            if (txtTelepon.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nomor telepon tidak boleh lebih dari 13 digit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nama tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTahunMasuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Menghentikan input karakter yang bukan angka
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtTahunMasuk.Text.Length >= 4 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nomor telepon tidak boleh lebih dari 13 digit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
