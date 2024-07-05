using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using PROJECT_PRG2.CRUD_Prodi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJECT_PRG2.CRUD_Dosen
{
    public partial class ViewDosen : Form
    {
        private bool panelDataMuncul = false;
        private bool panelTransaksiMuncul = false;
        private bool panelLaporanMuncul = false;
        private int step = 10;

        public ViewDosen()
        {
            InitializeComponent();
            
        }

        private void ViewDosen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet7.MataKuliah);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter.Fill(this.fINDSMARTDataSet7.Dosen);
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            // Your code to display data in DataGridView
        }


        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Link the Guna2ScrollBar to the DataGridView
            if (e.NewValue >= 0 && e.NewValue < dgvDosen.RowCount)
            {
                dgvDosen.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Link the Guna2ScrollBar to the DataGridView
            if (e.NewValue >= 0 && e.NewValue <= dgvDosen.HorizontalScrollingOffset)
            {
                dgvDosen.HorizontalScrollingOffset = e.NewValue;
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputDosen inputDosen = new InputDosen();
            inputDosen.Show();

            toolTipTambah.SetToolTip(btnTambah, "Tambah Data");
        }

        

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cek jika tombol yang ditekan adalah karakter valid (bukan karakter kontrol seperti backspace)
            if (!char.IsControl(e.KeyChar))
            {
                // Tambahkan karakter baru ke teks pencarian saat ini
                string teksPencarian = txtCari.Text + e.KeyChar;

                // Panggil metode untuk menyaring DataGridView
                FilterDataGridView(teksPencarian);
            }
            else if (e.KeyChar == (char)Keys.Back && txtCari.Text.Length > 0)
            {
                // Tangani tombol backspace
                string teksPencarian = txtCari.Text.Substring(0, txtCari.Text.Length - 1);
                FilterDataGridView(teksPencarian);
            }
        }

        private void FilterDataGridView(string teksPencarian)
        {
            // Asumsikan `dosenTableAdapter` adalah adapter dan `fINDSMART` adalah DataSet
            string query = $@"SELECT * FROM Dosen WHERE 
            No_Pegawai LIKE '%{teksPencarian}%' OR 
            NIDN LIKE '%{teksPencarian}%' OR 
            Nama LIKE '%{teksPencarian}%' OR 
            Bidang_Kompetensi LIKE '%{teksPencarian}%' OR 
            Pendidikan_Terakhir LIKE '%{teksPencarian}%' OR 
            Tanggal_Lahir LIKE '%{teksPencarian}%' OR 
            Jenis_Kelamin LIKE '%{teksPencarian}%' OR 
            Alamat LIKE '%{teksPencarian}%' OR 
            Email LIKE '%{teksPencarian}%' OR 
            Telepon LIKE '%{teksPencarian}%'
            ";

            // Buat DataTable baru untuk menampung hasil pencarian
            DataTable hasilPencarian = new DataTable();

            // Gunakan adapter untuk mengisi DataTable dengan hasil pencarian
            using (var adapter = new SqlDataAdapter(query, dosenTableAdapter.Connection))
            {
                adapter.Fill(hasilPencarian);
            }

            // Perbarui DataGridView dengan hasil pencarian
            dgvDosen.DataSource = hasilPencarian;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah txtPegawai kosong
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Silakan isi No Pegawai terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("select * from Dosen where No_Pegawai= @No_Pegawai", connection);
                    myCommand.Parameters.AddWithValue("@No_Pegawai", txtPegawai.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtPegawai.Text = dataTable.Rows[0]["No_Pegawai"].ToString();
                        txtNIDN.Text = dataTable.Rows[0]["NIDN"].ToString();
                        txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                        txtBidang.Text = dataTable.Rows[0]["Bidang_Kompetensi"].ToString();
                        txtPendidikan.Text = dataTable.Rows[0]["Pendidikan_Terakhir"].ToString();

                        // Convert Tanggal_Lahir to DateTime
                        DateTime tanggalLahir;
                        if (DateTime.TryParse(dataTable.Rows[0]["Tanggal_Lahir"].ToString(), out tanggalLahir))
                        {
                            DateTimeTanggal.Value = tanggalLahir;
                        }

                        // Set the radio button based on Jenis_Kelamin
                        string jenisKelamin = dataTable.Rows[0]["Jenis_Kelamin"].ToString();
                        rbLaki.Checked = jenisKelamin == "Laki-laki";
                        rbPerempuan.Checked = jenisKelamin == "Perempuan";
                        txtAlamat.Text = dataTable.Rows[0]["Alamat"].ToString();
                        txtEmail.Text = dataTable.Rows[0]["Email"].ToString();
                        txtTelepon.Text = dataTable.Rows[0]["Telepon"].ToString();
                    }

                    txtPegawai.Enabled = true;
                    txtNIDN.Enabled = true;
                    txtNama.Enabled = true;
                    txtBidang.Enabled = true;
                    txtPendidikan.Enabled = true;
                    DateTimeTanggal.Enabled = true;
                    rbLaki.Enabled = true;
                    rbPerempuan.Enabled = true;
                    txtAlamat.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelepon.Enabled = true;

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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdateDosen", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    string jenisKelamin = rbLaki.Checked ? "Laki-laki" : "Perempuan";

                    // Tambahkan parameter untuk stored procedure
                    update.Parameters.AddWithValue("@No_Pegawai", txtPegawai.Text);
                    update.Parameters.AddWithValue("@NIDN", txtNIDN.Text);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Bidang_Kompetensi", txtBidang.Text);
                    update.Parameters.AddWithValue("@Pendidikan_Terakhir", txtPendidikan.Text);
                    update.Parameters.AddWithValue("@Tanggal_Lahir", DateTimeTanggal.Value);
                    update.Parameters.AddWithValue("@Jenis_Kelamin", jenisKelamin);
                    update.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                    update.Parameters.AddWithValue("@Email", txtEmail.Text);
                    update.Parameters.AddWithValue("@Telepon", txtTelepon.Text);

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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand delete = new SqlCommand("sp_DeleteDosen", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@No_Pegawai", txtPegawai.Text);

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
            txtPegawai.Text = "";
            txtNIDN.Text = "";
            txtNama.Text = "";
            txtBidang.Text = "";
            txtPendidikan.Text = "";
            DateTimeTanggal.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPerempuan.Checked = false;
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtTelepon.Text = "";
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvDsn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan indeks baris yang diklik valid dan tidak negatif
            if (e.RowIndex >= 0 && e.RowIndex < dgvDosen.Rows.Count)
            {
                // Dapatkan baris yang diklik
                DataGridViewRow row = dgvDosen.Rows[e.RowIndex];

                // Isi nilai ke komponen yang sesuai
                txtPegawai.Text = row.Cells["No_Pegawai"].Value?.ToString();
                txtNIDN.Text = row.Cells["NIDN"].Value?.ToString();
                txtNama.Text = row.Cells["Nama"].Value?.ToString();
                txtBidang.Text = row.Cells["Bidang_Kompetensi"].Value?.ToString();
                txtPendidikan.Text = row.Cells["Pendidikan_Terakhir"].Value?.ToString();

                // Konversi Tanggal_Lahir ke DateTime
                DateTime tanggalLahir;
                if (DateTime.TryParse(row.Cells["Tanggal_Lahir"].Value?.ToString(), out tanggalLahir))
                {
                    DateTimeTanggal.Value = tanggalLahir;
                }

                // Set radio button berdasarkan Jenis_Kelamin
                string jenisKelamin = row.Cells["Jenis_Kelamin"].Value?.ToString();
                rbLaki.Checked = jenisKelamin == "Laki-laki";
                rbPerempuan.Checked = jenisKelamin == "Perempuan";

                txtAlamat.Text = row.Cells["Alamat"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtTelepon.Text = row.Cells["Telepon"].Value?.ToString();

                // Pastikan komponen enabled untuk memungkinkan pengeditan
                txtNIDN.Enabled = true;
                txtNama.Enabled = true;
                txtBidang.Enabled = true;
                txtPendidikan.Enabled = true;
                DateTimeTanggal.Enabled = true;
                rbLaki.Enabled = true;
                rbPerempuan.Enabled = true;
                txtAlamat.Enabled = true;
                txtEmail.Enabled = true;
                txtTelepon.Enabled = true;

                btnUpdate.Enabled = true;
                btnHapus.Enabled = true;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter.Fill(this.fINDSMARTDataSet7.Dosen);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter.Fill(this.fINDSMARTDataSet7.Dosen);
            // Ensure the Guna2DataGridView scrollbars are set correctly
            this.dgvDosen.ScrollBars = ScrollBars.Both;

            // Ensure AutoSizeColumnsMode is set
            this.dgvDosen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ensure some columns exceed the width of the DataGridView
            foreach (DataGridViewColumn column in dgvDosen.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                column.Width = 200; // Adjust this width as necessary
            }

            // Refresh the DataGridView to ensure scrollbars appear
            this.dgvDosen.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPendidikan_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tooltipupdate_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tooltipHapus_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

