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

namespace PROJECT_PRG2.CRUD_Pengumuman
{
    public partial class UpdatePengumuman : Form
    {
        public UpdatePengumuman()
        {
            InitializeComponent();
        }


        private void UpdatePengumuman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Pengumuman' table. You can move, or remove it, as needed.
            this.pengumumanTableAdapter.Fill(this.fINDSMARTDataSet7.Pengumuman);

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtIdMatkul kosong
                if (string.IsNullOrWhiteSpace(txtIDPengumuman.Text))
                {
                    MessageBox.Show("ID Pengumuman masih kosong.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);//validasi jika ID pengumuman kosong 
                    return;
                }

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("select * from Pengumuman where Id_Pengumuman= @Id_Pengumuman", connection);
                    myCommand.Parameters.AddWithValue("@Id_Pengumuman", txtIDPengumuman.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIDPengumuman.Text = dataTable.Rows[0]["Id_Pengumuman"].ToString();
                        txtPengumuman.Text = dataTable.Rows[0]["Nama"].ToString();
                        tglPengumuman.Text = DateTime.Now.ToString();
                        txtDeskripsi.Text = dataTable.Rows[0]["Deskripsi"].ToString();
                        
                        cbIDTendik.SelectedText = dataTable.Rows[0]["Id_TKN"].ToString();
                    }
                    else

                    {
                        MessageBox.Show("ID Pengumuman tidak ditemukan.","Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Warning); //Validasi jika ID tidak ditemukan
                    }
                    txtIDPengumuman.Enabled = true;
                    txtPengumuman.Enabled = true;
                    tglPengumuman.Enabled = true;
                    txtDeskripsi.Enabled = true;
                    
                    cbIDTendik.Enabled = true;

                    btnUpdatePengumuman.Enabled = true;
                    btnHapusPengumuman.Enabled = true;
                    btnTambah.Enabled = true;

                        connection.Close();
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePengumuman_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdateMatkul", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter untuk stored procedure
                    update.Parameters.AddWithValue("@Id_Pengumuman", txtIDPengumuman.Text);
                    update.Parameters.AddWithValue("@Nama", txtPengumuman.Text);
                    update.Parameters.AddWithValue("@Tanggal", tglPengumuman.Value);
                    update.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
                    
                    update.Parameters.AddWithValue("@Id_TKN", cbIDTendik.SelectedValue);
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
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear()
        {
            txtIDPengumuman.Text = "";
            txtPengumuman.Text = "";
            tglPengumuman.Value = DateTime.Now;
            txtDeskripsi.Text = "";
           
            cbIDTendik.SelectedValue = "";
        }

        private void btnBatalPengumuman_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnHapusPengumuman_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    SqlCommand delete = new SqlCommand("sp_DeletePengumuman", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("@Id_Pengumuman", txtIDPengumuman.Text);
                    //delete.Parameters.AddWithValue("@Status", "Tidak Aktif");

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

        private void txtPengumuman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya masukkan huruf!");
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Pengumuman pengumuman = new Pengumuman();
            pengumuman.Show();
        }
    }
}