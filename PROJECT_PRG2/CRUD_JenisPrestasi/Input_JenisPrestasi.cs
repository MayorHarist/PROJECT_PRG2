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
    public partial class Input_JenisPrestasi : Form
    {
        public Input_JenisPrestasi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=DESKTOP-1B9620N\\MSSQLSERVER01;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            // Meletakkan masukan pengguna dalam variabel
            string idJenisPrestasi = txtIdJenisPrestasi.Text;
            string nama = txtNama.Text;
            string peran = txtPeran.Text;
            string penyelenggara = txtPenyelenggara.Text;
            string point = txtPoint.Text;
            string status = txtStatus.Text;

            // Periksa apakah ada inputan kosong
            if (string.IsNullOrEmpty(idJenisPrestasi) || string.IsNullOrEmpty(nama) ||
                string.IsNullOrEmpty(peran) || string.IsNullOrEmpty(penyelenggara) ||
                string.IsNullOrEmpty(point) || string.IsNullOrEmpty(status))
            {
                // Tampilkan pesan kesalahan
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan eksekusi jika ada input yang kosong
            }

            // Tampilkan data yang telah diinputkan untuk konfirmasi
            string message = $"Apakah data berikut sudah benar?\n\n" +
                             $"ID Jenis Prestasi: {idJenisPrestasi}\n" +
                             $"Nama: {nama}\n" +
                             $"Peran: {peran}\n" +
                             $"Penyelenggara: {penyelenggara}\n" +
                             $"Point: {point}\n" +
                             $"Status: {status}";

            DialogResult result = MessageBox.Show(message, "Konfirmasi Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Jika pengguna menekan 'No', hentikan proses submit
            }


            SqlCommand insert = new SqlCommand("sp_InsertJenisPrestasi", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_JenisPrestasi", txtIdJenisPrestasi.Text);
            insert.Parameters.AddWithValue("Nama", txtNama.Text);
            insert.Parameters.AddWithValue("Peran", txtPeran.Text);
            insert.Parameters.AddWithValue("Penyelenggara", txtPenyelenggara.Text);
            insert.Parameters.AddWithValue("Point", txtPoint.Text);
            insert.Parameters.AddWithValue("Status", txtStatus.Text);

            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data jenis prestasi berhasil disimpan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal simpan: " + ex.Message);
            }
        }

        private void clear()
        {
            txtIdJenisPrestasi.Text = "";
            txtNama.Text = "";
            txtPeran.Text = "";
            txtPenyelenggara.Text = "";
            txtPoint.Text = "";
            txtStatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Menghentikan input karakter yang bukan angka
                MessageBox.Show("Point diisikan hanya oleh angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
