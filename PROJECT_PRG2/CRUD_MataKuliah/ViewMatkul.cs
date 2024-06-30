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
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet6.MataKuliah);
            // TODO: This line of code loads data into the 'fINDSMART.MataKuliah' table. You can move, or remove it, as needed.


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
            inputMatkul.ShowDialog();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    update.Parameters.AddWithValue("@Id_Matkul", txtIdMatkul.Text);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Jumlah_SKS", txtSKS.Text);
                    update.Parameters.AddWithValue("@Jenis", txtJenis.Text);
                    update.Parameters.AddWithValue("@Semester", txtSemester.Text);
                    update.Parameters.AddWithValue("@Status", txtStatus.Text);
                    update.Parameters.AddWithValue("@No_Pegawai", cbPegawai.SelectedText);
                    update.Parameters.AddWithValue("@Id_Prodi", cbProdi.SelectedText);

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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeleteMatkul", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@Id_Matkul", txtIdMatkul.Text);
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

        private void clear()
        {
            txtIdMatkul.Text = "";
            txtNama.Text = "";
            txtSKS.Text = "";
            txtJenis.Text = "";
            txtSemester.Text = "";
            txtStatus.Text = "";
            cbPegawai.SelectedText = "";
            cbProdi.SelectedText = "";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtIdMatkul kosong
                if (string.IsNullOrWhiteSpace(txtIdMatkul.Text))
                {
                    MessageBox.Show("Silakan isi Id Mata Kuliah dahulu.", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("select * from MataKuliah where Id_Matkul= @Id_Matkul", connection);
                    myCommand.Parameters.AddWithValue("@Id_Matkul", txtIdMatkul.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIdMatkul.Text = dataTable.Rows[0]["Id_Matkul"].ToString();
                        txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                        txtSKS.Text = dataTable.Rows[0]["Jumlah_SKS"].ToString();
                        txtJenis.Text = dataTable.Rows[0]["Jenis"].ToString();
                        txtSemester.Text = dataTable.Rows[0]["Semester"].ToString();
                        txtStatus.Text = dataTable.Rows[0]["Status"].ToString();
                        cbPegawai.SelectedText = dataTable.Rows[0]["No_Pegawai"].ToString();
                        cbProdi.SelectedText = dataTable.Rows[0]["Id_Prodi"].ToString();
                    }

                    txtNama.Enabled = true;
                    txtSKS.Enabled = true;
                    txtJenis.Enabled = true;
                    txtSemester.Enabled = true;
                    txtStatus.Enabled = true;
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dosenTableAdapter.FillBy(this.fINDSMARTDataSet1.Dosen);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.programStudiTableAdapter.FillBy(this.fINDSMARTDataSet2.ProgramStudi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dosenTableAdapter.FillBy1(this.fINDSMARTDataSet1.Dosen);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
