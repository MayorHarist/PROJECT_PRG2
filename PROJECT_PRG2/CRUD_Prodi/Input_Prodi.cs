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
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertProdi", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_Prodi", txtIdProdi.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Jenjang_Pendidikan", txtJenjangPendidikan.Text);
            insert.Parameters.AddWithValue("Akreditasi", txtAkreditasi.Text);
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
            txtIdProdi.Text = "";
            txtNama.Text = "";
            txtJenjangPendidikan.Text = "";
            txtAkreditasi.Text = "";
            txtStatus.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();    
        }
    }
}
