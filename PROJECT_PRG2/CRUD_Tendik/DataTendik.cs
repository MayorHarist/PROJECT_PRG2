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

namespace PROJECT_PRG2.CRUD_Tendik
{
    public partial class DataTendik : Form
    {
        public DataTendik()
        {
            InitializeComponent();

        }

        private void DataTendik_Load(object sender, EventArgs e)
        {

        }

        private void btnTambahTendik_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=false; data source=.; user=sa2; password=polman; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertDosen", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("ID TKN", txtIDTendik.Text);
            insert.Parameters.AddWithValue("Nama", txtNamaTendik.Text);
            insert.Parameters.AddWithValue("Tanggal_Lahir", tglLahirTendik.Value);
            // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPuan.Checked ? "Perempuan" : string.Empty;
            insert.Parameters.AddWithValue("Jenis_Kelamin", jenisKelamin);
            insert.Parameters.AddWithValue("Alamat", txtAlmatTendik.Text);
            insert.Parameters.AddWithValue("Email", txtEmailTendik.Text);
            insert.Parameters.AddWithValue("Telepon", TelpTendik.Text);
            insert.Parameters.AddWithValue("Username", userNmTendik.Text);
            insert.Parameters.AddWithValue("Password", txtPassTendik.Text);
            insert.Parameters.AddWithValue("Status", txtStatusTendik.Text);

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
            txtIDTendik.Text = "";
            txtNamaTendik.Text = "";
            tglLahirTendik.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPuan.Checked = false;
            txtAlmatTendik.Text = "";
            txtEmailTendik.Text = "";
            TelpTendik.Text = "";
            userNmTendik.Text = "";
            txtPassTendik.Text = "";
            txtStatusTendik.Text = "";
        }

        public string autoid()
        {
            string connectionstring = "integrated security=false; data source=.; user=sa2; password=polman; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM Tenaga Kependidikan";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "TKN" + count.ToString("000");

                    txtIDTendik.Text = newID;
                    return newID;
                }
            }
        }

        private void btnBatalTendik_Click(object sender, EventArgs e)
        {
            clear();
            
        }
    }
}
