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
    public partial class UDJepres : Form
    {
        public UDJepres()
        {
            InitializeComponent();
        }

        private void UDJepres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet8.JenisPrestasi' table. You can move, or remove it, as needed.
            //this.jenisPrestasiTableAdapter.Fill(this.fINDSMARTDataSet8.JenisPrestasi);

        }

        public void clear()
        {
            txtIdJenisPrestasi.Text = "";
            txtNama.Text = "";
            txtPeran.Text = "";
            txtPenyelenggara.Text = "";
            txtPoint.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form InputJepres
            InputJepres inputJepres = new InputJepres();

            // Menampilkan form InputJepres
            inputJepres.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet8.JenisPrestasi' table. You can move, or remove it, as needed.
            this.jenisPrestasiTableAdapter.Fill(this.fINDSMARTDataSet8.JenisPrestasi);
        }

        private void btnPerbaharui_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);
                {
                    connection.Open();
                    SqlCommand update = new SqlCommand("sp_UpdateJenisPrestasi", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    //tambahkan parameter untuk stored procedure
                    update.Parameters.AddWithValue("@Id_JenisPrestasi", txtIdJenisPrestasi.Text);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Peran", txtPeran.Text);
                    update.Parameters.AddWithValue("@Penyelenggara", txtPenyelenggara.Text);
                    update.Parameters.AddWithValue("Point", txtPoint.Text);

                    //eksekusi stored procedure
                    update.ExecuteNonQuery();

                    //Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Data Jenis Prestasi berhasil diperbaharui", "Informasi", MessageBoxButtons.OK,
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeleteJenisPrestasi", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@Id_JenisPrestasi", txtIdJenisPrestasi.Text);
                delete.ExecuteNonQuery();

                MessageBox.Show("Data jenis prestasi berhasil dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connnectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connnectionString);
                connection.Open();

                DataTable dataTable = new DataTable();
                SqlCommand myCommand = new SqlCommand("Select * from JenisPrestasi where Id_JenisPrestasi= @Id_JenisPrestasi", connection);
                myCommand.Parameters.AddWithValue("@Id_JenisPrestasi", txtCari.Text);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dataTable);

                txtIdJenisPrestasi.Text = dataTable.Rows[0]["Id_JenisPrestasi"].ToString();
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

        private void txtIdJenisPrestasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol yang ditekan adalah backspace atau delete
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true; // Membatalkan aksi penghapusan
                MessageBox.Show("Id sudah dibuat otomatis", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
