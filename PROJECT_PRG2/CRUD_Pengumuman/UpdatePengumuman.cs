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

        private void clear()
        {
            txtCariPM.Text = "";
            txtPengumuman.Text = "";
            tglPengumuman.Value = DateTime.Now;
            txtDeskripsi.Text = "";
           
            cbIDTendik.SelectedValue = "";
        }
        private void txtPengumuman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya masukkan huruf!");
            }
        }
        private void btnCari__Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCariPM.Text))
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
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM ProgramStudi WHERE Id_Prodi=@Id_Prodi", connection);
                    myCommand.Parameters.AddWithValue("@Id_Prodi", txtCariPM.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIDPM.Text = dataTable.Rows[0]["Id_Pengumuman"].ToString();
                        txtPengumuman.Text = dataTable.Rows[0]["Nama"].ToString();
                        // Convert Tanggal_Lahir to DateTime
                        DateTime tanggalpengumuman;
                        if (DateTime.TryParse(dataTable.Rows[0]["Tanggal"].ToString(), out tanggalpengumuman))
                        {
                            tglPengumuman.Value = tanggalpengumuman;
                        }
                        txtDeskripsi.Text = dataTable.Rows[0]["Deskripsi"].ToString();
                        cbIDTendik.SelectedValue = dataTable.Rows[0]["Id_TKN"].ToString();

                        txtIDPM.Enabled = true;
                        txtPengumuman.Enabled = true;
                        tglPengumuman.Enabled = true;
                        txtDeskripsi.Enabled = true;
                        cbIDTendik.Enabled = true;

                        btnUpPengumuman.Enabled = true;
                        btnHapusPM.Enabled = true;
                    }
                    else
                    {
                        // Menampilkan pesan jika data tidak ditemukan
                        MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTambahPengumuman_Click(object sender, EventArgs e)
        {
            Pengumuman pengumuman = new Pengumuman();
            pengumuman.Show();

            // Menambahkan tooltip untuk ImageButton
            toolTip1.SetToolTip(btnTambahPengumuman, "Tambah Data");
        }

        private void btnUpPengumuman_Click(object sender, EventArgs e)
        {
            
            try
            {
                //string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdatePengumuman", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter sesuai dengan input dari form
                    update.Parameters.AddWithValue("@Id_Pengumuman", txtIDPM.Text);

                    if (cbIDTendik.SelectedValue == null)
                    {
                        MessageBox.Show("Silakan pilih Tendik.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    update.Parameters.AddWithValue("@Id_TKN", txtIDPM.Text);
                    update.Parameters.AddWithValue("@Nama", txtPengumuman.Text);
                    update.Parameters.AddWithValue("@Tanggal", tglPengumuman.Value);
                    update.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
                    update.Parameters.AddWithValue("@Id_TKN", cbIDTendik.SelectedValue);

                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Memperbarui data di tampilan (jika ada)
                    this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);
                    this.pengumumanTableAdapter.Fill(this.fINDSMARTDataSet7.Pengumuman);
                    clear();

                    // Menambahkan tooltip untuk ImageButton
                    tooltipupdate.SetToolTip(btnTambahPengumuman, "Perbarui Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapusPM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //string connectionString = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
                    string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    /*SqlCommand delete = new SqlCommand("sp_DeletePengumuman", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("@Id_Pengumuman", txtCariPM.Text);
                    //delete.Parameters.AddWithValue("@Status", "Tidak Aktif");

                    delete.ExecuteNonQuery();*/

                    SqlCommand delete = new SqlCommand("DELETE FROM Pengumuman WHERE Id_Pengumuman = @Id_Pengumuman", connection);
                    delete.Parameters.AddWithValue("@Id_Pengumuman", txtIDPM.Text);
                    delete.ExecuteNonQuery();



                    MessageBox.Show("Data berhasil dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    // Menambahkan tooltip untuk ImageButton
                    tooltipHapus.SetToolTip(btnTambahPengumuman, "Hapus Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Pengumuman' table. You can move, or remove it, as needed.
            this.pengumumanTableAdapter.Fill(this.fINDSMARTDataSet7.Pengumuman);
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            this.pengumumanTableAdapter.Fill(this.fINDSMARTDataSet7.Pengumuman);

        }
    }
}