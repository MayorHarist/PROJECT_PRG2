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
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            txtIdJenisPrestasi.Text = "";
            txtNama.Text = "";
            txtPeran.Text = "";
            txtPenyelenggara.Text = "";
            txtPoint.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
