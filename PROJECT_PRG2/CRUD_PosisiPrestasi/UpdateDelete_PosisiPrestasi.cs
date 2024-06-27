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
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.PosisiPrestasi' table. You can move, or remove it, as needed.
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet7.PosisiPrestasi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.PosisiPrestasi' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fINDSMARTDataSet5.PosisiPrestasi' table. You can move, or remove it, as needed.
           

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
            txtDeskripsi.Text = "";
        }

        /*        private void btnUbah_Click(object sender, EventArgs e)
                {
                    DialogResult result = MessageBox.Show("Apakah anda yakin ingin update data posisi prestasi?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return; // Jika pengguna memilih 'No', hentikan proses update
                    }

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
                        clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }*/

        private void btnUbah_Click(object sender, EventArgs e)
        {

            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                /*connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT Nama, Status FROM PosisiPrestasi WHERE Id_PosisiPrestasi = @Id_PosisiPrestasi", connection);
                checkCommand.Parameters.AddWithValue("Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
                SqlDataReader reader = checkCommand.ExecuteReader();

                if (reader.Read())
                {
                    string existingNama = reader["Nama"].ToString();
                    string existingStatus = reader["Status"].ToString();
                    reader.Close();

                    if (existingNama == txtNama.Text && existingStatus == txtStatus.Text)
                    {
                        MessageBox.Show("Tidak ada perubahan pada data.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tidak ada perubahan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah anda yakin ingin update data posisi prestasi?", "Konfirmasi Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Jika pengguna memilih 'No', hentikan proses update
                }

                SqlCommand myCommand = new SqlCommand("UPDATE PosisiPrestasi SET Nama = @Nama, Status = @Status WHERE Id_PosisiPrestasi = @Id_PosisiPrestasi", connection);
                myCommand.Parameters.AddWithValue("Nama", txtNama.Text);
                myCommand.Parameters.AddWithValue("Status", txtStatus.Text);
                myCommand.Parameters.AddWithValue("Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);

                myCommand.ExecuteNonQuery();
                MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();*/
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdatePosisiPrestasi", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    //tambahkan parameter untuk stored procedure
                    update.Parameters.AddWithValue("@Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);

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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*        private void btnHapus_Click(object sender, EventArgs e)
               {
                   DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data posisi prestasi?", "Konfirmasi Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if (result == DialogResult.No)
                   {
                       return; // Jika pengguna memilih 'No', hentikan proses delete
                   }

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
               }*/

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                connection.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT 1 FROM PosisiPrestasi WHERE Id_PosisiPrestasi = @Id_PosisiPrestasi", connection);
                checkCommand.Parameters.AddWithValue("Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
                object exists = checkCommand.ExecuteScalar();

                if (exists == null)
                {

                    MessageBox.Show("Tidak ada data yang dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus data posisi prestasi?", "Konfirmasi Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Jika pengguna memilih 'No', hentikan proses delete
                }

                SqlCommand delete = new SqlCommand("sp_DeletePosisiPrestasi", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("@Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
                //delete.Parameters.AddWithValue("@Status", "Tidak Aktif");
                delete.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet7.PosisiPrestasi);
        }
    }
}
