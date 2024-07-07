using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_MataKuliah
{
    public partial class InputMatkul : Form
    {
        public InputMatkul()
        {
            InitializeComponent();
            autoid();
            //this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter.Fill(this.fINDSMARTDataSet7.Dosen);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.Dosen);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi apakah semua field telah diisi
            if (string.IsNullOrWhiteSpace(txtIdMatkul.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtSKS.Text) ||
                string.IsNullOrWhiteSpace(txtJenis.Text) ||
                string.IsNullOrWhiteSpace(txtSemester.Text) ||
                cbPegawai.SelectedValue == null ||
                cbProdi.SelectedValue == null)
            {
                MessageBox.Show("Silakan lengkapi semua data terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi tambahan sesuai kebutuhan
            // Misalnya, validasi untuk SKS harus angka
            int sks;
            if (!int.TryParse(txtSKS.Text, out sks))
            {
                MessageBox.Show("Jumlah SKS harus berupa angka.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konstruksi teks konfirmasi
            string dataKonfirmasi = "Data yang akan disimpan:\n\n" +
                             "ID Mata Kuliah: " + txtIdMatkul.Text + "\n" +
                             "Nama: " + txtNama.Text + "\n" +
                             "Jumlah SKS: " + txtSKS.Text + "\n" +
                             "Jenis: " + txtJenis.Text + "\n" +
                             "Semester: " + txtSemester.Text + "\n" +
                             "Pegawai: " + cbPegawai.Text + "\n" +
                             "Program Studi: " + cbProdi.Text + "\n\n" +
                             "Apakah Anda yakin ingin menyimpan data?";

            DialogResult result = MessageBox.Show(dataKonfirmasi, "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART_MABRES";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand insert = new SqlCommand("sp_InsertMatkul", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("@Id_Matkul", txtIdMatkul.Text);
                insert.Parameters.AddWithValue("@Nama", txtNama.Text);
                insert.Parameters.AddWithValue("@Jumlah_SKS", txtSKS.Text);
                insert.Parameters.AddWithValue("@Jenis", txtJenis.Text);
                insert.Parameters.AddWithValue("@Semester", txtSemester.Text);
                insert.Parameters.AddWithValue("@No_Pegawai", cbPegawai.SelectedValue.ToString());
                insert.Parameters.AddWithValue("@Id_Prodi", cbProdi.SelectedValue.ToString());

                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tidak dapat menyimpan data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private bool Validasi()
        {
            if (string.IsNullOrWhiteSpace(txtIdMatkul.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtSKS.Text) ||
                string.IsNullOrWhiteSpace(txtJenis.Text) ||
                string.IsNullOrWhiteSpace(txtSemester.Text) ||
                cbPegawai.SelectedValue == null ||
                cbProdi.SelectedValue == null)
            {
                MessageBox.Show("Semua data harus diisi !", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtSKS.Text, out _))
            {
                MessageBox.Show("Data Jumlah SKS harus berupa angka.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtSemester.Text, out _))
            {
                MessageBox.Show("Data Semester harus berupa angka.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtJenis.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Data Jenis harus berisi hanya huruf.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtNama.Text = "";
            txtSKS.Text = "";
            txtJenis.Text = "";
            txtSemester.Text = "";
            cbPegawai.SelectedValue = "";
            cbProdi.SelectedValue = "";
        }

        private void InputMatkul_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.Dosen);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter.Fill(this.fINDSMARTDataSet7.Dosen);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet6.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter.Fill(this.fINDSMARTDataSet6.Dosen);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet2.ProgramStudi' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fINDSMARTDataSet1.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter.Fill(this.fINDSMARTDataSet1.Dosen);

        }

        public string autoid()
        {
            string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART_MABRES";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string functionQuery = "SELECT dbo.autoIdMatkul()";

                using (SqlCommand functionCommand = new SqlCommand(functionQuery, connection))
                {
                    string newID = functionCommand.ExecuteScalar().ToString();
                    txtIdMatkul.Text = newID;
                    return newID;
                }
            }
        }



        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
