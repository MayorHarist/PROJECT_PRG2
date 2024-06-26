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
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet6.TenagaKependidikan);
            // TODO: This line of code loads data into the 'tendik.TenagaKependidikan' table. You can move, or remove it, as needed.
            

        }
        private void btnCariTendik_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtPegawai kosong
                if (string.IsNullOrWhiteSpace(txtIDTendik.Text))
                {
                    MessageBox.Show("Data ID harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM TenagaKependidikan WHERE Id_TKN=@Id_TKN", connection);
                    myCommand.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
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

                        // Set the radio button based on Jenis_Kelamin
                        string jenisKelamin = dataTable.Rows[0]["Jenis_Kelamin"].ToString();
                        rbLaki.Checked = jenisKelamin == "Laki-laki";
                        rbPuan.Checked = jenisKelamin == "Perempuan";
                        txtAlmatTendik.Text = dataTable.Rows[0]["Alamat"].ToString();
                        txtEmailTendik.Text = dataTable.Rows[0]["Email"].ToString();
                        TelpTendik.Text = dataTable.Rows[0]["Telepon"].ToString();
                        userNmTendik.Text = dataTable.Rows[0]["Username"].ToString();
                        txtPassTendik.Text = dataTable.Rows[0]["Password"].ToString();
                        txtStatusTendik.Text = dataTable.Rows[0]["Status"].ToString();
                    }

                    txtIDTendik.Enabled = true;
                    txtNamaTendik.Enabled = true;
                    tglLahirTendik.Enabled = true;
                    rbLaki.Enabled = true;
                    rbPuan.Enabled = true;
                    txtAlmatTendik.Enabled = true;
                    txtEmailTendik.Enabled = true;
                    TelpTendik.Enabled = true;
                    userNmTendik.Enabled = true;
                    txtPassTendik.Enabled= true;
                    txtStatusTendik.Enabled = true;

                    btnUbahTendik.Enabled = true;
                    btnHapusTendik.Enabled = true;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUbahTendik_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionstring))
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
                    update.Parameters.AddWithValue("@Status", txtStatusTendik.Text);

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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            txtIDTendik.Text = "";
            txtNamaTendik.Text = "";
            tglLahirTendik.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPuan.Checked = false;
            txtAlmatTendik.Text = "";
            txtEmailTendik.Text = "";
            TelpTendik.Text = "";
            userNmTendik.Text = "";
            txtPassTendik.Text = "";
            txtStatusTendik.Text = "";
        }

        private void btnHapusTendik_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeleteTendik", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
                delete.Parameters.AddWithValue("@Status", "Tidak Aktif");

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
}
