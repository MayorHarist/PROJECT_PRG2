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
    public partial class UpdateDelete_JenisPrestasi : Form
    {
        public UpdateDelete_JenisPrestasi()
        {
            InitializeComponent();
            txtNama.Enabled = false;
            txtPeran.Enabled = false;
            txtPenyelenggara.Enabled = false;
            txtPoint.Enabled = false;
            txtStatus.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connnectionstring = "integrated security=true; data source=.; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connnectionstring);
            SqlCommand cmd = new SqlCommand("sp_CariJenisSupplier", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Id_JenisSupplier", txtIdJenisPrestasi.Text);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtNama.Enabled = true;
                txtPeran.Enabled = true;
                txtPenyelenggara.Enabled = true;
                txtPoint.Enabled = true;
                txtStatus.Enabled = true;

                txtNama.Text = reader["Nama"].ToString();
                txtPeran.Text = reader["Peran"].ToString();
                txtPenyelenggara.Text = reader["Penyelenggara"].ToString();
                txtPoint.Text = reader["Point"].ToString();
                txtStatus.Text = reader["status"].ToString();
            }
            else
            {
                MessageBox.Show("Data jenis prestasi tidak ditemui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            txtNama.Enabled = false;
            txtPeran.Enabled = false;
            txtPenyelenggara.Enabled = false;
            txtPoint.Enabled = false;
            txtStatus.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data soruce=.; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand update = new SqlCommand("sp_UpdateJenisPrestasi", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("Id_JenisPrestasi", txtIdJenisPrestasi.Text);
            update.Parameters.AddWithValue("Nama", txtNama.Text);
            update.Parameters.AddWithValue("Peran", txtPeran.Text);
            update.Parameters.AddWithValue("Penyelenggara", txtPenyelenggara.Text);
            update.Parameters.AddWithValue("Point", txtPoint.Text);
            update.Parameters.AddWithValue("Status", txtStatus.Text);
            connection.Open();
            update.ExecuteNonQuery();

            MessageBox.Show("Data berhasil diperbaharui", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data soruce=.; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand("sp_DeleteJenisPrestasi", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("Id_JenisPrestasi", txtIdJenisPrestasi.Text);
            MessageBox.Show("Anda yakin menghapus data ini?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak berhasil disimpan" + ex.Message);
            }
        }
    }
}