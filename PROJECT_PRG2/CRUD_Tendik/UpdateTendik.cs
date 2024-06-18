using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Tendik
{
    public partial class UpdateTendik : Form
    {
        public UpdateTendik()
        {
            InitializeComponent();
        }

        private void UpdateTendik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter1.Fill(this.fINDSMART.TenagaKependidikan);
            // TODO: This line of code loads data into the 'dsTendik.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter.Fill(this.dsTendik.TenagaKependidikan);
        }

        private void btnCariTendik_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                DataTable dataTable = new DataTable();
                SqlCommand myCommand = new SqlCommand("SELECT * FROM TenagaKependidikan WHERE Id_TKN=@Id_TKN", connection);
                myCommand.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    txtIDTendik.Text = dataTable.Rows[0]["Id_TKN"].ToString();
                    txtNamaTendik.Text = dataTable.Rows[0]["nama_customer"].ToString();
                    tglLahirTendik.Value = Convert.ToDateTime(dataTable.Rows[0]["Tanggal_Lahir"]);
                    string jenisKelamin = dataTable.Rows[0]["Jenis_Kelamin"].ToString();
                    if (jenisKelamin == "Laki-Laki")
                    {
                        rbLaki.Checked = true;
                    }
                    else if (jenisKelamin == "Perempuan")
                    {
                        rbPuan.Checked = true;
                    }
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
                rbLaki.Checked = false;
                rbPuan.Checked = false;
                txtAlmatTendik.Enabled = true;
                txtEmailTendik.Enabled = true;
                TelpTendik.Enabled = true;
                userNmTendik.Enabled = true;
                txtPassTendik.Enabled = true;
                txtStatusTendik.Enabled = true;

                btnBatalUpTendik.Enabled = true;
                btnHapusTendik.Enabled = true;
                btnUbahTendik.Enabled = true;

                connection.Close();
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }
           
        }



        private void txtIDTendik_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUbahTendik_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=false; data source=.; user=sa2; password=polman; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_UpdateTendik", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
            insert.Parameters.AddWithValue("@Tendik", txtNamaTendik.Text);
            insert.Parameters.AddWithValue("@Tanggal_Lahir", tglLahirTendik.Value);
            // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPuan.Checked ? "Perempuan" : string.Empty;
            insert.Parameters.AddWithValue("@Jenis_Kelamin", jenisKelamin);
            insert.Parameters.AddWithValue("@Alamat", txtAlmatTendik.Text);
            insert.Parameters.AddWithValue("@Email", txtEmailTendik.Text);
            insert.Parameters.AddWithValue("@Telepon", TelpTendik.Text);
            insert.Parameters.AddWithValue("@Username", userNmTendik.Text);
            insert.Parameters.AddWithValue("@Password", txtPassTendik.Text);
            insert.Parameters.AddWithValue("@Status", txtStatusTendik.Text);

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
                string connectionstring = "integrated security=false; data source=.; user=sa2; password=polman; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand myCommand = new SqlCommand("sp_DeleteTendik", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);

                connection.Open();
                int result = Convert.ToInt32(myCommand.ExecuteNonQuery());
                connection.Close();

                // cek apakah ada data yang ditambahkan
                if (result != 0)
                {
                    MessageBox.Show("Hapus data Produk berhasil");
                }
                else
                {
                    MessageBox.Show("Hapus data Produk gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnBatalUpTendik_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
