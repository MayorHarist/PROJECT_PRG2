using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertDosen", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("No_Pegawai", txtPegawai.Text);
            insert.Parameters.AddWithValue("NIDN", txtNIDN.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Bidang_Kompetensi", txtBidang.Text);
            insert.Parameters.AddWithValue("Pendidikan_Terakhir", txtPendidikan.Text);
            insert.Parameters.AddWithValue("Tanggal_Lahir", DateTimeTanggal.Value);
            // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPerempuan.Checked ? "Perempuan" : string.Empty;
            insert.Parameters.AddWithValue("Jenis_Kelamin", jenisKelamin);
            insert.Parameters.AddWithValue("Alamat", txtAlamat.Text);
            insert.Parameters.AddWithValue("Email", txtEmail.Text);
            insert.Parameters.AddWithValue("Telepon", txtTelepon.Text);
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
            txtStatus.Text = "";
        }

        public string autoid()
        {
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01;initial catalog=FINDSMART";
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


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardDosen dashboardDosen = new DashboardDosen();
            dashboardDosen.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InputDosen inputDosen = new InputDosen();
            inputDosen.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewDosen viewDosen = new ViewDosen();
            viewDosen.Show();
            this.Hide();
        }

        private void btnUpdateDel_Click(object sender, EventArgs e)
        {
            UpdateDeleteDosen updateDeleteDosen = new UpdateDeleteDosen();
            updateDeleteDosen.Show();
            this.Hide();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            LoginSbgTenDik loginSbgTenDik = new LoginSbgTenDik();
            loginSbgTenDik.Show();
            this.Hide();
        }

        private void InputDosen_Load(object sender, EventArgs e)
        {

        }

        private void DateTimeTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
