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
using static Guna.UI2.Native.WinApi;

namespace PROJECT_PRG2.CRUD_PosisiPrestasi
{
    public partial class InputPospres : Form
    {
        public InputPospres()
        {
            InitializeComponent();
            autoid();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        public string autoid()
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM PosisiPrestasi";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "PP" + count.ToString("000");

                    txtIdPosisiPrestasi.Text = newID;
                    return newID;
                }
            }
        }

        private void clear()
        {
            //txtIdPosisiPrestasi.Text = "";
            txtNama.Text = "";
            txtDeskripsi.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            //Validasi masukan pengguna dalam variabel
            string idposisiprestasi = txtIdPosisiPrestasi.Text;
            string nama = txtNama.Text;
            string deskripsi = txtDeskripsi.Text;


            if (string.IsNullOrEmpty(idposisiprestasi) || string.IsNullOrEmpty(nama) ||
                string.IsNullOrEmpty(deskripsi))

            {
                // Tampilkan pesan kesalahan
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan eksekusi jika ada input yang kosong
            }

            // Tampilkan data yang telah diinputkan untuk konfirmasi
            string message = $"Apakah data berikut sudah benar?\n\n" +
                             $"ID Jenis Prestasi: {idposisiprestasi}\n" +
                             $"Nama: {nama}\n" +
                             $"Peran: {deskripsi}\n";

            DialogResult result = MessageBox.Show(message, "Konfirmasi Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna menekan 'No', hentikan proses submit
            }

            SqlCommand insert = new SqlCommand("sp_InsertPosisiPrestasi", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_PosisiPrestasi", txtIdPosisiPrestasi.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Deskripsi", txtDeskripsi.Text);

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
                MessageBox.Show("Gagal untuk disimpan: " + ex.Message);
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

        private void txtIdPosisiPrestasi_KeyPress(object sender, KeyPressEventArgs e)
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
