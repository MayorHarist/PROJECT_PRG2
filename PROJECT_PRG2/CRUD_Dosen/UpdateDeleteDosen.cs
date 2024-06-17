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

namespace PROJECT_PRG2.CRUD_Dosen
{
    public partial class UpdateDeleteDosen : Form
    {
        public UpdateDeleteDosen()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                DataTable dataTable = new DataTable();
                SqlCommand myCommand = new SqlCommand("select * from Dosen where No_Pegawai= @No_Pegawai", connection);
                myCommand.Parameters.AddWithValue("@No_Pegawai", txtPegawai.Text);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    txtPegawai.Text = dataTable.Rows[0]["No_Pegawai"].ToString();
                    txtNIDN.Text = dataTable.Rows[0]["NIDN"].ToString();
                    txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                    txtBidang.Text = dataTable.Rows[0]["Bidang_Kompetensi"].ToString();
                    txtPendidikan.Text = dataTable.Rows[0]["Pendidikan_Terakhir"].ToString();

                    // Convert Tanggal_Lahir to DateTime
                    DateTime tanggalLahir;
                    if (DateTime.TryParse(dataTable.Rows[0]["Tanggal_Lahir"].ToString(), out tanggalLahir))
                    {
                        DateTimeTanggal.Value = tanggalLahir;
                    }

                    // Set the radio button based on Jenis_Kelamin
                    string jenisKelamin = dataTable.Rows[0]["Jenis_Kelamin"].ToString();
                    rbLaki.Checked = jenisKelamin == "Laki-laki";
                    rbPerempuan.Checked = jenisKelamin == "Perempuan";
                    txtAlamat.Text = dataTable.Rows[0]["Alamat"].ToString();
                    txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                    txtStatus.Text = dataTable.Rows[0]["Status"].ToString();
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
                txtStatus.Enabled = true;

                btnUbah.Enabled = true;
                btnHapus.Enabled = true;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand update = new SqlCommand("sp_UpdateDosen", connection);
                update.CommandType = CommandType.StoredProcedure;

                string jenisKelamin;

                if (rbLaki.Checked)
                {
                    jenisKelamin = "Laki - laki";
                }
                else
                {
                    jenisKelamin = "Perempuan";
                }

                update.CommandText = "UPDATE Dosen " +
                                     "SET NIDN = @NIDN, " +
                                     "    Nama = @Nama, " +
                                     "    Bidang_Kompetensi = @Bidang_Kompetensi, " +
                                     "    Pendidikan_Terakhir = @Pendidikan_Terakhir, " +
                                     "    Tanggal_Lahir = @Tanggal_Lahir " +
                                     "    Jenis_Kelamin = @Jenis_Kelamin " +
                                     "    Alamat = @Alamat " +
                                     "    Email = @Email " +
                                     "    Telepon = @Telepon " +
                                     "    Status = @Status " +
                                     "WHERE No_Pegawai = @No_Pegawai";

                // Tambahkan parameter untuk menghindari SQL injection dan masalah dengan nilai string
                update.Parameters.AddWithValue("No_Pegawai", txtPegawai.Text);
                update.Parameters.AddWithValue("NIDN", txtNIDN.Text);
                update.Parameters.AddWithValue("Nama", txtNama.Text);
                update.Parameters.AddWithValue("Bidang_Kompetensi", txtBidang.Text);
                update.Parameters.AddWithValue("Pendidikan_Terakhir", txtPendidikan.Text);
                update.Parameters.AddWithValue("Tanggal_Lahir", DateTimeTanggal.Value);
                update.Parameters.AddWithValue("Jenis_Kelamin", jenisKelamin);
                update.Parameters.AddWithValue("Alamat", txtAlamat.Text);
                update.Parameters.AddWithValue("Email", txtEmail.Text);
                update.Parameters.AddWithValue("Telepon", txtTelepon.Text);
                update.Parameters.AddWithValue("Status", txtStatus.Text);

                // Eksekusi perintah SQL
                update.ExecuteNonQuery();



                update.ExecuteNonQuery();

                //menampilkan pesan jika eksekusi berhasil
                MessageBox.Show("Basisdata berhasil diperbaharui", "informasi", MessageBoxButtons.OK,
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
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);
                
                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeleteDosen", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@No_Pegawai", txtPegawai.Text);
                delete.Parameters.AddWithValue("@Status", "Tidak Aktif");

                delete.ExecuteNonQuery();


                MessageBox.Show("Data berhasil dihapus", "Informasi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
