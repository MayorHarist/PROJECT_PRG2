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
    public partial class InputMatkul : Form
    {
        public InputMatkul()
        {
            InitializeComponent();
            autoid();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01;initial catalog=FINDSMART";
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
                MessageBox.Show("Data berhasil disimpan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }
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
