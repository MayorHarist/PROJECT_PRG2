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

namespace PROJECT_PRG2.CRUD_MataKuliah
{
    public partial class ViewMatkul : Form
    {
        public ViewMatkul()
        {
            InitializeComponent();
        }

        private void ViewMatkul_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dATASET_DEAN.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter3.Fill(this.dATASET_DEAN.Dosen);
            // TODO: This line of code loads data into the 'dATASET_DEAN.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter3.Fill(this.dATASET_DEAN.ProgramStudi);
            // TODO: This line of code loads data into the 'dATASET_DEAN.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter3.Fill(this.dATASET_DEAN.MataKuliah);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.Dosen);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.MataKuliah' table. You can move, or remove it, as needed.
            //this.mataKuliahTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.MataKuliah);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.Dosen);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            ///this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.MataKuliah' table. You can move, or remove it, as needed.
            ///this.mataKuliahTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.MataKuliah);
            /* // TODO: This line of code loads data into the 'fINDSMARTDataSet7.ProgramStudi' table. You can move, or remove it, as needed.
             this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
             // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Dosen' table. You can move, or remove it, as needed.
             this.dosenTableAdapter.Fill(this.fINDSMARTDataSet7.Dosen);
             // TODO: This line of code loads data into the 'fINDSMARTDataSet7.MataKuliah' table. You can move, or remove it, as needed.
             this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet7.MataKuliah);

             // TODO: This line of code loads data into the 'fINDSMARTDataSet6.MataKuliah' table. You can move, or remove it, as needed.
             //this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet6.MataKuliah);
             // TODO: This line of code loads data into the 'fINDSMART.MataKuliah' table. You can move, or remove it, as needed.

             this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet7.MataKuliah);*/

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
           
        }

        private void mataKuliahBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void gdvMatkul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputMatkul inputMatkul = new InputMatkul();
            inputMatkul.Show();
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validasi apakah semua data telah terisi
            if (string.IsNullOrWhiteSpace(txtIdMatkul.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtSKS.Text) ||
                string.IsNullOrWhiteSpace(txtJenis.Text) ||
                string.IsNullOrWhiteSpace(txtSemester.Text) ||
                string.IsNullOrWhiteSpace(txtKelas.Text) ||
                cbPegawai.SelectedValue == null ||
                cbProdi.SelectedValue == null)
            {
                MessageBox.Show("Silakan isi semua data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tampilkan kotak dialog konfirmasi
            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin mengubah data berikut?\n\n" +
                $"ID Mata Kuliah: {txtIdMatkul.Text}\n" +
                $"Nama: {txtNama.Text}\n" +
                $"Jumlah SKS: {txtSKS.Text}\n" +
                $"Jenis: {txtJenis.Text}\n" +
                $"Semester: {txtSemester.Text}\n" +
                $"Kelas: {txtKelas.Text}\n" +
                $"No Pegawai: {cbPegawai.SelectedValue.ToString()}\n" +
                $"ID Prodi: {cbProdi.SelectedValue.ToString()}\n",
                "Konfirmasi Pembaruan Data",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Jika pengguna memilih 'No', batalkan pembaruan
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdateMatkul", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter untuk stored procedure
                    update.Parameters.AddWithValue("@Id_Matkul", txtIdMatkul.Text);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Jumlah_SKS", Convert.ToInt32(txtSKS.Text));
                    update.Parameters.AddWithValue("@Jenis", txtJenis.Text);
                    update.Parameters.AddWithValue("@Semester", Convert.ToInt32(txtSemester.Text));
                    update.Parameters.AddWithValue("@Kelas", txtKelas.Text);
                    update.Parameters.AddWithValue("@No_Pegawai", cbPegawai.SelectedValue.ToString());
                    update.Parameters.AddWithValue("@Id_Prodi", cbProdi.SelectedValue.ToString());

                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();
                    this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet7.MataKuliah);

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



        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Validasi apakah ID Mata Kuliah telah diisi
            if (string.IsNullOrWhiteSpace(txtIdMatkul.Text))
            {
                MessageBox.Show("Silakan pilih data yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tampilkan kotak dialog konfirmasi
            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus data mata kuliah dengan ID {txtIdMatkul.Text}?",
                "Konfirmasi Penghapusan Data",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Jika pengguna memilih 'No', batalkan penghapusan
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Menggunakan SqlCommand untuk menjalankan perintah DELETE yang akan memicu trigger trgInsteadOfDeleteMatkul
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM Matakuliah WHERE Id_Matkul = @Id_Matkul", connection);
                    deleteCommand.Parameters.AddWithValue("@Id_Matkul", txtIdMatkul.Text);
                    deleteCommand.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Data berhasil dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh data grid atau tindakan lain setelah penghapusan
                    //this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet7.MataKuliah);
                    clear(); // Memanggil metode clear untuk membersihkan input fields
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void clear()
        {
            txtCari.Text = "";
            txtIdMatkul.Text = "";
            txtNama.Text = "";
            txtSKS.Text = "";
            txtJenis.Text = "";
            txtSemester.Text = "";
            txtKelas.Text = "";
            cbPegawai.SelectedValue = "";
            cbProdi.SelectedValue = "";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtCari kosong
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Silakan isi Id Mata Kuliah dahulu.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("sp_CariMatkul", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@Cari", txtCari.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIdMatkul.Text = dataTable.Rows[0]["Id_Matkul"].ToString();
                        txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                        txtSKS.Text = dataTable.Rows[0]["Jumlah_SKS"].ToString();
                        txtJenis.Text = dataTable.Rows[0]["Jenis"].ToString();
                        txtSemester.Text = dataTable.Rows[0]["Semester"].ToString();
                        txtKelas.Text = dataTable.Rows[0]["Kelas"].ToString();
                        cbPegawai.SelectedValue = dataTable.Rows[0]["No_Pegawai"].ToString();
                        cbProdi.SelectedValue = dataTable.Rows[0]["Id_Prodi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    txtIdMatkul.Enabled = true;
                    txtNama.Enabled = true;
                    txtSKS.Enabled = true;
                    txtJenis.Enabled = true;
                    txtSemester.Enabled = true;
                    txtKelas.Enabled = true;
                    cbPegawai.Enabled = true;
                    cbProdi.Enabled = true;

                    btnUpdate.Enabled = true;
                    btnHapus.Enabled = true;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            //this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet7.MataKuliah);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.Dosen);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.MataKuliah' table. You can move, or remove it, as needed.
            //this.mataKuliahTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.MataKuliah;
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.MataKuliah' table. You can move, or remove it, as needed.
            //this.mataKuliahTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.MataKuliah);
            this.mataKuliahTableAdapter3.Fill(this.dATASET_DEAN.MataKuliah);
        }

        private void txtSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
