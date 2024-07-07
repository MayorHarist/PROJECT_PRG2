using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Tendik
{
    public partial class UpTendik : Form
    {
        public UpTendik()
        {
            InitializeComponent();
        }

        private void UpTendik_Load(object sender, EventArgs e)
        {
            
        }

        private void clear()
        {
            txtNamaTendik.Text = "";
            tglLahirTendik.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPuan.Checked = false;
            txtAlmatTendik.Text = "";
            txtEmailTendik.Text = "";
            TelpTendik.Text = "";
            userNmTendik.Text = "";
            txtPassTendik.Text = "";
        }
        private void btnTambahTendik_Click(object sender, EventArgs e)
        {
            DataTendik dataTendik = new DataTendik();
            dataTendik.Show();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard_KepalaTendik dashboard_KepalaTendik = new Dashboard_KepalaTendik();
            dashboard_KepalaTendik.Show();
            this.Hide();
        }

        private void btnCari__Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtPegawai kosong
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Data ID harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //string connectionString = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM TenagaKependidikan WHERE Id_TKN=@Id_TKN", connection);
                    myCommand.Parameters.AddWithValue("@Id_TKN", txtCari.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIDTendik.Text = dataTable.Rows[0]["Id_TKN"].ToString();
                        txtNamaTendik.Text = dataTable.Rows[0]["Nama"].ToString();
                        // Convert Tanggal_Lahir to DateTime
                        DateTime tanggalLahir;
                        if (DateTime.TryParse(dataTable.Rows[0]["Tanggal_Lahir"].ToString(), out tanggalLahir))
                        {
                            tglLahirTendik.Value = tanggalLahir;
                        }
                        if (dataTable.Rows.Count > 0)
                        {
                            // Set the radio button based on Jenis_Kelamin
                            string jenisKelamin = dataTable.Rows[0]["Jenis_Kelamin"].ToString();
                            rbLaki.Checked = jenisKelamin == "Laki-laki";
                            rbPuan.Checked = jenisKelamin == "Perempuan";
                            txtAlmatTendik.Text = dataTable.Rows[0]["Alamat"].ToString();
                            txtEmailTendik.Text = dataTable.Rows[0]["Email"].ToString();
                            TelpTendik.Text = dataTable.Rows[0]["Telepon"].ToString();
                            userNmTendik.Text = dataTable.Rows[0]["Username"].ToString();
                            txtPassTendik.Text = dataTable.Rows[0]["Password"].ToString();

                            txtIDTendik.Enabled = true;
                            txtNamaTendik.Enabled = true;
                            tglLahirTendik.Enabled = true;
                            rbLaki.Enabled = true;
                            rbPuan.Enabled = true;
                            txtAlmatTendik.Enabled = true;
                            txtEmailTendik.Enabled = true;
                            TelpTendik.Enabled = true;
                            userNmTendik.Enabled = true;
                            txtPassTendik.Enabled = true;

                            btnUpdate.Enabled = true;
                            btnHapus_.Enabled = true;
                        }
                        else
                        {
                            // Menampilkan pesan jika data tidak ditemukan
                            MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdateTendik", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
                    update.Parameters.AddWithValue("@Nama", txtNamaTendik.Text);
                    update.Parameters.AddWithValue("@Tanggal_Lahir", tglLahirTendik.Value);
                    // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
                    string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPuan.Checked ? "Perempuan" : string.Empty;
                    update.Parameters.AddWithValue("@Jenis_Kelamin", jenisKelamin);
                    update.Parameters.AddWithValue("@Alamat", txtAlmatTendik.Text);
                    update.Parameters.AddWithValue("@Email", txtEmailTendik.Text);
                    update.Parameters.AddWithValue("@Telepon", TelpTendik.Text);
                    update.Parameters.AddWithValue("@Username", userNmTendik.Text);
                    update.Parameters.AddWithValue("@Password", txtPassTendik.Text);

                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Memperbarui data di tampilan (jika ada)
                    this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus__Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //string connectionString = "integrated security=false; data source=.;  user=sa; password=polman; initial catalog=FINDSMART";
                    string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    SqlCommand delete = new SqlCommand("DELETE FROM TenagaKependidikan WHERE Id_TKN = @Id_TKN", connection);
                    delete.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
                    delete.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);
        }
    }
}
