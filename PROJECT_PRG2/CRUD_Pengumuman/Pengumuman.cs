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
    public partial class Pengumuman : Form
    {
        public Pengumuman()
        {
            InitializeComponent();
            autoid();
        }

        private void btnTambahPengumuman_Click(object sender, EventArgs e)
        {
            //string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            SqlConnection connection = new SqlConnection(connectionString);

            // Memastikan apakah data yang akan diismpan sudah benar, jika belum maka masih bisa mengisi ulang sebelum simpan
            string message = $"Apakah data berikut sudah benar?\n\n" +
                    $"Id_Pengumuman: {txtIDPengumuman.Text}\n" +
                    $"Nama: {txtPengumuman.Text}\n" +
                    $"Tanggal: {tglPengumuman.Value}\n" +
                    $"Deskripsi: {txtDeskripsi.Text}\n" +
                    $"Id_TKN : {cbIDTendik.Text}\n";

            DialogResult result = MessageBox.Show(message, "Konfirmasi Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna menekan 'No', hentikan proses submit
            }

            SqlCommand insert = new SqlCommand("sp_InsertPengumuman", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("@Id_Pengumuman", txtIDPengumuman.Text);
            insert.Parameters.AddWithValue("@Nama", txtPengumuman.Text);
            insert.Parameters.AddWithValue("@Tanggal", tglPengumuman.Value);
            insert.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);

            // Ensure SelectedValue is not null and cast it to the correct type
            if (cbIDTendik.SelectedValue != null)
            {
                insert.Parameters.AddWithValue("@Id_TKN", cbIDTendik.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Pilih Id_TKN yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create Required Validator untuk verifikasi masukan pengguna wajib diisi,
            // dengan memeriksa apakah semua data terisi atau belum
            if (string.IsNullOrWhiteSpace(txtIDPengumuman.Text) || string.IsNullOrWhiteSpace(txtPengumuman.Text) ||
                string.IsNullOrWhiteSpace(tglPengumuman.Text) || string.IsNullOrWhiteSpace(txtDeskripsi.Text))
            {
                MessageBox.Show("Seluruh Data Wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                MessageBox.Show("Unable to save: " + ex.Message);
            }
            finally
            {
                connection.Close();
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

        public string autoid()
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string functionQuery = "SELECT dbo.autoIdPengumuman()";

                using (SqlCommand functionCommand = new SqlCommand(functionQuery, connection))
                {
                    string newID = functionCommand.ExecuteScalar().ToString();
                    txtIDPengumuman.Text = newID;
                    return newID;
                }
            }
        }


        private void btnBatalPengumuman_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Pengumuman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);

        }

        private void txtPengumuman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
