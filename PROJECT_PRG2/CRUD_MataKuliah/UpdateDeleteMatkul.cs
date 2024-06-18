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

namespace PROJECT_PRG2.CRUD_MataKuliah
{
    public partial class UpdateDeleteMatkul : Form
    {
        public UpdateDeleteMatkul()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtIdMatkul kosong
                if (string.IsNullOrWhiteSpace(txtIdMatkul.Text))
                {
                    MessageBox.Show("Silakan isi Id Mata Kuliah dahulu.", "Peringatan", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("select * from MataKuliah where Id_Matkul= @Id_Matkul", connection);
                    myCommand.Parameters.AddWithValue("@Id_Matkul", txtIdMatkul.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIdMatkul.Text = dataTable.Rows[0]["Id_Matkul"].ToString();
                        txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                        txtSKS.Text = dataTable.Rows[0]["Jumlah_SKS"].ToString();
                        txtJenis.Text = dataTable.Rows[0]["Jenis"].ToString();
                        txtSemester.Text = dataTable.Rows[0]["Semester"].ToString();
                        cbPegawai.SelectedText = dataTable.Rows[0]["No_Pegawai"].ToString();
                        cbProdi.SelectedText = dataTable.Rows[0]["Id_Prodi"].ToString();
                    }

                    txtNIDN.Enabled = true;
                    txtNama.Enabled = true;
                    txtBidang.Enabled = true;
                    txtPendidikan.Enabled = true;
                    DateTimeTanggal.Enabled = true;
                    rbLaki.Enabled = true;
                    rbPerempuan.Enabled = true;
                    txtAlamat.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelepon.Enabled = true;
                    txtStatus.Enabled = true;

                    btnUbah.Enabled = true;
                    btnHapus.Enabled = true;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
