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
    public partial class UpDelet_Prodi : Form
    {
        public UpDelet_Prodi()
        {
            InitializeComponent();
        }

        private void UpDelet_Prodi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet3.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet3.ProgramStudi);

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtPegawai kosong
                if (string.IsNullOrWhiteSpace(txtIdProdi.Text))
                {
                    MessageBox.Show("Data ID harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string connectionString = "integrated security=false; data source=DESKTOP-1B9620N\\MSSQLSERVER01; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM ProgramStudi WHERE Id_Prodi=@Id_Prodi", connection);
                    myCommand.Parameters.AddWithValue("@Id_Prodi", txtIdProdi.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIdProdi.Text = dataTable.Rows[0]["Id_Prodi"].ToString();
                        txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                        txtJenjangPendidikan.Text = dataTable.Rows[0]["Jenjang_Pendidikan"].ToString();
                        txtAkreditasi.Text = dataTable.Rows[0]["Akreditasi"].ToString();
                        txtStatusTendik.Text = dataTable.Rows[0]["Status"].ToString();
                    }

                    txtIdProdi.Enabled = true;
                    txtNama.Enabled = true;
                    txtJenjangPendidikan.Enabled = true;
                    txtAkreditasi.Enabled = true;
                    txtStatusTendik.Enabled = true;

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

        private void btnUbah_Click(object sender, EventArgs e)
        {

        }
    }
}
