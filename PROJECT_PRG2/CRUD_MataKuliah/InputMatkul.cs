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
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (Validasi())
            {
                string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand insert = new SqlCommand("sp_InsertMatkul", connection);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("Id_Matkul", txtIdMatkul.Text);
                insert.Parameters.AddWithValue("Nama", txtNama.Text);
                insert.Parameters.AddWithValue("Jumlah_SKS", txtSKS.Text);
                insert.Parameters.AddWithValue("Jenis", txtJenis.Text);
                insert.Parameters.AddWithValue("Semester", txtSemester.Text);
                insert.Parameters.AddWithValue("Status", txtStatus.Text);
                insert.Parameters.AddWithValue("No_Pegawai", cbPegawai.SelectedValue);
                insert.Parameters.AddWithValue("Id_Prodi", cbProdi.SelectedValue);

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
            }
        }

        private bool Validasi()
        {
            if (string.IsNullOrWhiteSpace(txtIdMatkul.Text) ||
                string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtSKS.Text) ||
                string.IsNullOrWhiteSpace(txtJenis.Text) ||
                string.IsNullOrWhiteSpace(txtSemester.Text) ||
                string.IsNullOrWhiteSpace(txtStatus.Text) ||
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

            if (!Regex.IsMatch(txtStatus.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Data Status harus berisi hanya huruf.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtIdMatkul.Text = "";
            txtNama.Text = "";
            txtSKS.Text = "";
            txtJenis.Text = "";
            txtSemester.Text = "";
            txtStatus.Text = "";
            cbPegawai.SelectedValue = "";
            cbProdi.SelectedValue = "";
        }

        private void InputMatkul_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet6.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter.Fill(this.fINDSMARTDataSet6.Dosen);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet2.ProgramStudi' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fINDSMARTDataSet1.Dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter.Fill(this.fINDSMARTDataSet1.Dosen);

        }

        public string autoid()
        {
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM MataKuliah";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "M" + count.ToString("000");

                    txtIdMatkul.Text = newID;
                    return newID;
                }
            }
        }
    }
}
