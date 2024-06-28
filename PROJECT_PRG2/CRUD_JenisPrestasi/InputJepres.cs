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

namespace PROJECT_PRG2.CRUD_JenisPrestasi
{
    public partial class InputJepres : Form
    {
        public InputJepres()
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
                string countQuery = "SELECT COUNT(*) FROM JenisPrestasi";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "JP" + count.ToString("000");

                    txtIdJenisPrestasi.Text = newID;
                    return newID;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            //Validasi masukan pengguna dalam variabel
            string idjenisprestasi = txtIdJenisPrestasi.Text;
            string nama = txtNama.Text;
            string peran = txtPeran.Text;
            string penyelenggara = txtPenyelenggara.Text;
            int point;


            if (string.IsNullOrEmpty(idjenisprestasi) || string.IsNullOrEmpty(nama) ||
                string.IsNullOrEmpty(peran) || string.IsNullOrEmpty(penyelenggara))

            {
                // Tampilkan pesan kesalahan
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan eksekusi jika ada input yang kosong
            }

            if (!int.TryParse(txtPoint.Text, out point))
            {
                MessageBox.Show("Masukkan nilai numerik yang valid untuk Point", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tampilkan data yang telah diinputkan untuk konfirmasi
            string message = $"Apakah data berikut sudah benar?\n\n" +
                             $"ID Jenis Prestasi: {idjenisprestasi}\n" +
                             $"Nama: {nama}\n" +
                             $"Peran: {peran}\n" +
                             $"Penyelenggara: {penyelenggara}\n" +
                             $"Point: {point}\n";

            DialogResult result = MessageBox.Show(message, "Konfirmasi Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna menekan 'No', hentikan proses submit
            }

            SqlCommand insert = new SqlCommand("sp_InsertJenisPrestasi",connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_JenisPrestasi", txtIdJenisPrestasi.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Peran", txtPeran.Text);
            insert.Parameters.AddWithValue("Penyelenggara", txtPenyelenggara.Text);
            insert.Parameters.AddWithValue("Point", txtPoint.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gagal untuk disimpan: " + ex.Message);
            }
        }

        private void clear()
        {
            //txtIdJenisPrestasi.Text = "";
            txtNama.Text = "";
            txtPeran.Text = "";
            txtPenyelenggara.Text = "";
            txtPoint.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }


        //Validasi
        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) 
            {
                e.Handled = true;
                MessageBox.Show("Nama tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Point hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIdJenisPrestasi_KeyPress(object sender, KeyPressEventArgs e)
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
