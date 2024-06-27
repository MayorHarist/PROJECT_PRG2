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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                connection.Open();

                DataTable dataTable = new DataTable();
                SqlCommand myCommand = new SqlCommand("Select * from JenisPrestasi where Id_JenisPrestasi= @Id_JenisPrestasi", connection);
                myCommand.Parameters.AddWithValue("Id_JenisPrestasi", txtIdJenisPrestasi.Text);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dataTable);

                txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                txtPeran.Text = dataTable.Rows[0]["Peran"].ToString();
                txtPenyelenggara.Text = dataTable.Rows[0]["Penyelenggara"].ToString();
                txtPoint.Text = dataTable.Rows[0]["Point"].ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void clear()
        {
            txtIdJenisPrestasi.Text = "";
            txtNama.Text = "";
            txtPeran.Text = "";
            txtPenyelenggara.Text = "";
            txtPoint.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin update data jenis prestasi?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna memilih 'No', hentikan proses update
            }

            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                /*                connection.Open();

                                SqlCommand myCommand = new SqlCommand();
                                myCommand.Connection = connection;

                                myCommand.CommandText = "UPDATE JenisPrestasi " +
                                                        "SET Nama = @Nama, " +
                                                        "   Peran = @Peran, " +
                                                        "   Penyelenggara = @Penyelenggara, " +
                                                        "   Point = @Point, " +

                                                        "WHERE Id_JenisPrestasi = @Id_JenisPrestasi";

                                // Tambahkan parameter untuk menghindari SQL injection dan masalah dengan nilai string
                                myCommand.Parameters.AddWithValue("Nama", txtNama.Text);
                                myCommand.Parameters.AddWithValue("Peran", txtPeran.Text);
                                myCommand.Parameters.AddWithValue("Penyelenggara", txtPenyelenggara.Text);
                                myCommand.Parameters.AddWithValue("Point", txtPoint.Text);
                                myCommand.Parameters.AddWithValue("Id_JenisPrestasi", txtIdJenisPrestasi.Text);

                                //eksekusi perintah SQL
                                myCommand.ExecuteNonQuery();*/

                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdateJenisPrestasi", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    //tambahkan parameter untuk stored procedure
                    update.Parameters.AddWithValue("@Id_JenisPrestasi",txtIdJenisPrestasi.Text);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Peran", txtPeran.Text);
                    update.Parameters.AddWithValue("@Penyelenggara", txtPenyelenggara.Text);
                    update.Parameters.AddWithValue("@Point", txtPoint.Text);

                    //eksekusi stored procedure
                    update.ExecuteNonQuery();

                    //Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data jenis prestasi?", "Konfirmasi Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna memilih 'No', hentikan proses delete
            }

            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeleteJenisPrestasi", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@Id_JenisPrestasi", txtIdJenisPrestasi.Text);
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

        private void UpdateDelete_JenisPrestasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.JenisPrestasi' table. You can move, or remove it, as needed.
            this.jenisPrestasiTableAdapter2.Fill(this.fINDSMARTDataSet7.JenisPrestasi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.JenisPrestasi' table. You can move, or remove it, as needed.
            //this.jenisPrestasiTableAdapter1.Fill(this.fINDSMARTDataSet6.JenisPrestasi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet4.JenisPrestasi' table. You can move, or remove it, as needed.
            

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet4.JenisPrestasi' table. You can move, or remove it, as needed.
            //this.jenisPrestasiTableAdapter.Fill(this.fINDSMARTDataSet4.JenisPrestasi);
            this.jenisPrestasiTableAdapter2.Fill(this.fINDSMARTDataSet7.JenisPrestasi);
        }

        private void txtPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Menghentikan input karakter yang bukan angka
                MessageBox.Show("Point diisikan hanya oleh angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}