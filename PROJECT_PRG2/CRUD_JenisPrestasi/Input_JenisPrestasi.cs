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

namespace PROJECT_PRG2.CRUD_JenisPrestasi
{
    public partial class Input_JenisPrestasi : Form
    {
        public Input_JenisPrestasi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertJenisPrestasi", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_JenisPrestasi", txtIdJenisPrestasi.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Peran", txtPeran.Text);
            insert.Parameters.AddWithValue("Penyelenggara", txtPenyelenggara.Text);
            insert.Parameters.AddWithValue("Point", txtPoint.Text);
            insert.Parameters.AddWithValue("Status", txtStatus.Text);
            //insert.Parameters.AddWithValue("Status", cbStatus.SelectedValue.ToString());

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data jenis prestasi berhasil disimpan", "Informasi",
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
            txtIdJenisPrestasi.Text = "";
            txtNama.Text = "";
            txtPeran.Text = "";
            txtPenyelenggara.Text = "";
            txtPoint.Text = "";
            txtStatus.Text = "";
            //cbStatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
