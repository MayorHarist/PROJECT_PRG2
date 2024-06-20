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
    public partial class UpdatePengumuman : Form
    {
        public UpdatePengumuman()
        {
            InitializeComponent();
        }


        private void UpdatePengumuman_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtIdMatkul kosong
                if (string.IsNullOrWhiteSpace(txtIDPengumuman.Text))
                {
                    MessageBox.Show("Silakan isi Id Pengumuman dahulu.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("select * from Pengymuman where Id_Pengumuman= @Id_Pengumuman", connection);
                    myCommand.Parameters.AddWithValue("@Id_Pengumuman", txtIDPengumuman.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIDPengumuman.Text = dataTable.Rows[0]["Id_Matkul"].ToString();
                        txtPengumuman.Text = dataTable.Rows[0]["Nama"].ToString();
                        tglPengumuman.Text = DateTime.Now.ToString();
                        txtDeskripsi.Text = dataTable.Rows[0]["Jumlah_SKS"].ToString();
                        cbIDTendik.SelectedText = dataTable.Rows[0]["No_Pegawai"].ToString();
                        txtStatusPengumuman.Text = dataTable.Rows[0]["Status"].ToString();
                    }

                    txtIDPengumuman.Enabled = true;
                    txtPengumuman.Enabled = true;
                    tglPengumuman.Enabled = true;
                    txtDeskripsi.Enabled = true;
                    cbIDTendik.Enabled = true;
                    txtStatusPengumuman.Enabled = true;

                    btnUpdatePengumuman.Enabled = true;
                    btnHapusPengumuman.Enabled = true;
                    btnBatalPengumuman.Enabled = true;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePengumuman_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdateMatkul", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter untuk stored procedure
                    update.Parameters.AddWithValue("@Id_Pengumuman", txtIDPengumuman.Text);
                    update.Parameters.AddWithValue("@Nama", txtPengumuman.Text);
                    update.Parameters.AddWithValue("@Tanggal", tglPengumuman.Value);
                    update.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
                    update.Parameters.AddWithValue("@Id_TKN", cbIDTendik.SelectedValue);
                    update.Parameters.AddWithValue("@Status", txtStatusPengumuman.Text);
                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
