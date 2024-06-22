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
    public partial class InputMahasiswa : Form
    {
        public InputMahasiswa()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertMahasiswa", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("NIM", txtNIM.Text);
            insert.Parameters.AddWithValue("Id_Prodi", cbProdi.SelectedValue);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Tanggal_Lahir", DateTimeTanggal.Value);
            // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPerempuan.Checked ? "Perempuan" : string.Empty;
            insert.Parameters.AddWithValue("Jenis_Kelamin", jenisKelamin);
            insert.Parameters.AddWithValue("Alamat", txtAlamat.Text);
            insert.Parameters.AddWithValue("Email", txtEmail.Text);
            insert.Parameters.AddWithValue("Telepon", txtTelepon.Text);
            insert.Parameters.AddWithValue("Tahun_Masuk", txtTahunMasuk.Text);
            insert.Parameters.AddWithValue("Username", txtUsername.Text);
            insert.Parameters.AddWithValue("Password", txtPassword.Text);
            insert.Parameters.AddWithValue("Status", txtStatus.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        { 
            txtNIM.Text = "";
            cbProdi.SelectedValue = "";
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
            txtStatus.Text = "";
        }

        private void InputMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet6.ProgramStudi);
            

        }
    }
}
