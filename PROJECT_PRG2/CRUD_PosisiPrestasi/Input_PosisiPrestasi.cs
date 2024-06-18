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

namespace PROJECT_PRG2.CRUD_PosisiPrestasi
{
    public partial class Input_PosisiPrestasi : Form
    {
        public Input_PosisiPrestasi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertPosisiPrestasi", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Status", txtStatus.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data posisi prestasi berhasil disimpan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal simpan: " + ex.Message);
            }
        }

        private void clear()
        {
            txtIdPosisiPrestasi.Text = "";
            txtNama.Text = "";
            txtStatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
