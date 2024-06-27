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

namespace PROJECT_PRG2.CRUD_Prodi
{
    public partial class Input_Prodi : Form
    {
        public Input_Prodi()
        {
            InitializeComponent();
            autoid();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertProdi", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_Prodi", txtIdProdi.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Jenjang_Pendidikan", txtJenjangPendidikan.Text);
            insert.Parameters.AddWithValue("Akreditasi", txtAkreditasi.Text);
            

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
        public string autoid()
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM ProgramStudi";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "PROD" + count.ToString("000");

                    txtIdProdi.Text = newID;
                    return newID;
                }
            }
        }
        private void clear()
        {
            txtIdProdi.Text = "";
            txtNama.Text = "";
            txtJenjangPendidikan.Text = "";
            txtAkreditasi.Text = "";
            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();    
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DasboardTendik dasboardTendik = new DasboardTendik();
            dasboardTendik.Show();
            this.Hide();



        }
    }
}
