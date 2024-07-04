using PROJECT_PRG2.CRUD_JenisPrestasi;
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
    public partial class UDPospres : Form
    {
        public UDPospres()
        {
            InitializeComponent();
        }

        private void UDPospres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet71.PosisiPrestasi' table. You can move, or remove it, as needed.
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet71.PosisiPrestasi);

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
                myCommand.Parameters.AddWithValue("@Id_PosisiPrestasi", txtCari.Text);
                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                myAdapter.Fill(dataTable);

                txtIdPosisiPrestasi.Text = dataTable.Rows[0]["Id_PosisiPrestasi"].ToString();
                txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                txtDeskripsi.Text = dataTable.Rows[0]["Deskripsi"].ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnTambahPP_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form InputJepres
            InputPospres inputPospres = new InputPospres();
            // Menampilkan form InputJepres
            inputPospres.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet9.PosisiPrestasi' table. You can move, or remove it, as needed.
            //this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet9.PosisiPrestasi);
            //this.posisiPrestasiTableAdapter1.Fill(this.fINDSMARTDataSet7.PosisiPrestasi);
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet71.PosisiPrestasi);

        }

        private void clear()
        {
            txtNama.Text = "";
            txtDeskripsi.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnUpdatePP_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);
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
                    MessageBox.Show("Data Posisi Prestasi berhasil diperbaharui", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error: ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // TODO: This line of code loads data into the 'fINDSMARTDataSet9.PosisiPrestasi' table. You can move, or remove it, as needed.
            //this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet9.PosisiPrestasi);
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet71.PosisiPrestasi);
        }

        private void txtIdPosisiPrestasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Jika tombol yang ditekan adalah backspace atau delete
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = true; // Membatalkan aksi penghapusan
                MessageBox.Show("Id sudah dibuat otomatis", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapusPP_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeletePosisiPrestasi", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
                delete.ExecuteNonQuery();

                MessageBox.Show("Data posisi prestasi berhasil dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // TODO: This line of code loads data into the 'fINDSMARTDataSet9.PosisiPrestasi' table. You can move, or remove it, as needed.
            //this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet9.PosisiPrestasi);
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet71.PosisiPrestasi);
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nama tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
