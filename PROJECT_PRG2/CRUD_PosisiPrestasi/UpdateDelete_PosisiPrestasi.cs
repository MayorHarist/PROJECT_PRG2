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
    public partial class UpdateDelete_PosisiPrestasi : Form
    {
        public UpdateDelete_PosisiPrestasi()
        {
            InitializeComponent();
        }

        private void UpdateDelete_PosisiPrestasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet5.PosisiPrestasi' table. You can move, or remove it, as needed.
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet5.PosisiPrestasi);

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                connection.Open();

                DataTable dataTable = new DataTable();
                SqlCommand myCommand = new SqlCommand("Select * from PosisiPrestasi where Id_PosisiPrestasi= @Id_PosisiPrestasi", connection);
                myCommand.Parameters.AddWithValue("Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dataTable);

                txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                txtStatus.Text = dataTable.Rows[0]["Status"].ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void clear()
        {
            txtIdPosisiPrestasi.Text = "";
            txtNama.Text = "";
            txtStatus.Text = "";
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                connection.Open();

                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "UPDATE PosisiPrestasi " +
                                        "SET Nama = @Nama, " +
                                        "   Status = @Status " +
                                        "WHERE Id_PosisiPrestasi = @Id_PosisiPrestasi";

                // Tambahkan parameter untuk menghindari SQL injection dan masalah dengan nilai string
                myCommand.Parameters.AddWithValue("Nama", txtNama.Text);
                myCommand.Parameters.AddWithValue("Status", txtStatus.Text);
                myCommand.Parameters.AddWithValue("Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);

                //eksekusi perintah SQL
                myCommand.ExecuteNonQuery();

                //menampilkan pesan jika eksekusi berhasil
                MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeletePosisiPrestasi", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
                delete.Parameters.AddWithValue("@Status", "Tidak Aktif");
                delete.ExecuteNonQuery();


                MessageBox.Show("Data berhasil dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet5.PosisiPrestasi' table. You can move, or remove it, as needed.
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet5.PosisiPrestasi);
        }
    }
}
