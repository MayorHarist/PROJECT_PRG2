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

namespace PROJECT_PRG2.CRUD_PosisiPrestasi
{
    public partial class Input_PosisiPrestasi : Form
    {
        public Input_PosisiPrestasi()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=true; data source=.;initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            // Meletakkan masukan pengguna dalam variabel
            string idPosisiPrestasi = txtIdPosisiPrestasi.Text;
            string nama = txtNama.Text;
            string deskripsi = txtDeskripsi.Text;

            // Periksa apakah ada inputan kosong
            if (string.IsNullOrEmpty(idPosisiPrestasi) || string.IsNullOrEmpty(nama))
            {
                // Tampilkan pesan kesalahan
                MessageBox.Show("Seluruh data wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan eksekusi jika ada input yang kosong
            }

            // Tampilkan data yang telah diinputkan untuk konfirmasi
            string message = $"Apakah data berikut sudah benar?\n\n" +
                             $"ID Posisi Prestasi: {idPosisiPrestasi}\n" +
                             $"Nama: {nama}\n" +
                             $"Deskripsi: {deskripsi}\n";

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
                MessageBox.Show("Data posisi prestasi berhasil disimpan", "Informasi",
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
            txtIdPosisiPrestasi.Text = "";
            txtNama.Text = "";
            txtDeskripsi.Text ="";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
