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

namespace PROJECT_PRG2.CRUD_Pengumuman
{
    public partial class Pengumuman : Form
    {
        public Pengumuman()
        {
            InitializeComponent();
            autoid();
        }

        private void btnTambahPengumuman_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertPengumuman", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("@Id_Pengumuman", txtIDPengumuman.Text);
            insert.Parameters.AddWithValue("@Nama", txtPengumuman.Text);
            insert.Parameters.AddWithValue("@Tanggal", tglPengumuman.Value);
            insert.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
            insert.Parameters.AddWithValue("@Id_TKN", cbIDTendik.SelectedValue);
            insert.Parameters.AddWithValue("@Status", txtStatusPengumuman.Text);

            //Create Requred Validator untuk verifikasi masukan pengguna wajib diisi,
            //dengan memeriksa apakah semua data terisi atau belum
            if (string.IsNullOrWhiteSpace(txtIDPengumuman.Text) || string.IsNullOrWhiteSpace(txtPengumuman.Text) || string.IsNullOrWhiteSpace(tglPengumuman.Text) ||
                string.IsNullOrWhiteSpace(txtDeskripsi.Text) || string.IsNullOrWhiteSpace(txtStatusPengumuman.Text))
            {
                MessageBox.Show("Harap lengkapi semua data!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            txtIDPengumuman.Text = "";
            txtPengumuman.Text = "";
            tglPengumuman.Value = DateTime.Now;
            txtDeskripsi.Text = "";
            cbIDTendik.SelectedValue = "";
            txtStatusPengumuman.Text = "";
        }

        public string autoid()
        {
            string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM Pengumuman";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "PM" + count.ToString("000");

                    txtIDPengumuman.Text = newID;
                    return newID;
                }
            }
        }

        private void btnBatalPengumuman_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
