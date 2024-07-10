using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT_PRG2.Transaksi
{
    public partial class trsKRS : Form
    {
        string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART_MABRES";

        public trsKRS()
        {
            InitializeComponent();
            buatkolom();
            AutoidKRS();
        }

        private void trsKRS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.TransaksiKRS' table. You can move, or remove it, as needed.
            this.transaksiKRSTableAdapter.Fill(this.fINDSMART_MABRESDataSet1.TransaksiKRS);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMART_MABRESDataSet1.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);

            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.TenagaKependidikan);
         
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
        }

        // Method to generate new KRS ID
        public string AutoidKRS()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM TransaksiKRS";

                // Execute count query
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;
                    string newID = "KRS" + count.ToString("000");
                    txtidTrsKrs.Text = newID;
                    return newID;
                }
            }
        }

        // Method to generate new DetailMatkul ID
        public string AutoidDetMatkul()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM DetailMatkul";

                // Execute count query
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;
                    string newID = "DET" + count.ToString("000");
                    return newID;
                }
            }
        }

        // Method to create columns in DataGridView
        void buatkolom()
        {
            dtgDetailMatkul.Columns.Clear();
            dtgDetailMatkul.Columns.Add("Matkul", "Mata Kuliah");
            dtgDetailMatkul.Columns.Add("Nilai_Tugas", "Nilai Tugas");
            dtgDetailMatkul.Columns.Add("Nilai_Quiz", "Nilai Quiz");
            dtgDetailMatkul.Columns.Add("Nilai_UTS", "Nilai UTS");
            dtgDetailMatkul.Columns.Add("Nilai_UAS", "Nilai UAS");
            dtgDetailMatkul.Columns.Add("Nilai_Projek", "Nilai Projek");
            dtgDetailMatkul.Columns.Add("Nilai_Akhir", "Nilai Akhir");
            dtgDetailMatkul.Columns.Add("Indeks_Nilai", "Indeks Nilai");
        }

        // Button 'Tambah' click event handler
        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtNilaiTugas.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiQuiz.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiUTS.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiUAS.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiProjek.Text))
                {
                    MessageBox.Show("Please enter values in all fields.");
                    return;
                }

                // Get selected values
                string matkul = cbMatkul.SelectedValue.ToString();

                // Create a new row for DataGridView
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgDetailMatkul);

                // Set values for each cell in the new row
                row.Cells[0].Value = matkul;
                row.Cells[1].Value = txtNilaiTugas.Text;
                row.Cells[2].Value = txtNilaiQuiz.Text;
                row.Cells[3].Value = txtNilaiUTS.Text;
                row.Cells[4].Value = txtNilaiUAS.Text;
                row.Cells[5].Value = txtNilaiProjek.Text;

                // Calculate final grade and index
                decimal nilaiTugas = decimal.Parse(txtNilaiTugas.Text);
                decimal nilaiQuiz = decimal.Parse(txtNilaiQuiz.Text);
                decimal nilaiUTS = decimal.Parse(txtNilaiUTS.Text);
                decimal nilaiUAS = decimal.Parse(txtNilaiUAS.Text);
                decimal nilaiProjek = decimal.Parse(txtNilaiProjek.Text);
                decimal nilaiAkhir = (nilaiTugas + nilaiQuiz + nilaiUTS + nilaiUAS + nilaiProjek) / 5.0m;

                char indeksNilai;
                if (nilaiAkhir >= 85)
                    indeksNilai = 'A';
                else if (nilaiAkhir >= 70)
                    indeksNilai = 'B';
                else if (nilaiAkhir >= 60)
                    indeksNilai = 'C';
                else if (nilaiAkhir >= 40)
                    indeksNilai = 'D';
                else
                    indeksNilai = 'E';

                // Set calculated values to DataGridView
                row.Cells[6].Value = nilaiAkhir.ToString("N2");
                row.Cells[7].Value = indeksNilai.ToString();

                // Add new row to DataGridView
                dtgDetailMatkul.Rows.Add(row);

                // Calculate and display IP
                CalculateAndDisplayIP();

                // Clear input fields
                ClearFields();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid decimal numbers in all fields.\n" + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("The number entered is too large or too small.\n" + ex.Message);
            }
        }

        private void ClearFields()
        {
            // Clear TextBox values
            txtNilaiTugas.Text = "";
            txtNilaiQuiz.Text = "";
            txtNilaiUTS.Text = "";
            txtNilaiUAS.Text = "";
            txtNilaiProjek.Text = "";
            txtNilaiAkhir.Text = "";
            txtIndeksNilai.Text = "";

            // Reset ComboBox selection
            cbMatkul.SelectedIndex = -1;
        }


        // Method to calculate and display IP
        private void CalculateAndDisplayIP()
        {
            decimal totalNilaiSKS = 0;
            int totalSKS = 0;

            foreach (DataGridViewRow row in dtgDetailMatkul.Rows)
            {
                if (row.Cells[6].Value != null && row.Cells[7].Value != null)
                {
                    decimal nilaiAkhir = decimal.Parse(row.Cells[6].Value.ToString());
                    char indeksNilai = row.Cells[7].Value.ToString()[0];

                    string idMatkul = row.Cells[0].Value.ToString();
                    int sks = GetSKS(idMatkul);

                    decimal nilaiBobot = GetBobot(indeksNilai) * sks;
                    totalNilaiSKS += nilaiBobot;
                    totalSKS += sks;
                }
            }

            decimal ip = totalSKS > 0 ? totalNilaiSKS / totalSKS : 0;
            txtIP.Text = ip.ToString("N2");
        }

        // Method to get SKS based on Id_Matkul
        private int GetSKS(string idMatkul)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Jumlah_SKS FROM MataKuliah WHERE Id_Matkul = @Id_Matkul";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id_Matkul", idMatkul);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Method to get grade weight based on index
        private decimal GetBobot(char indeksNilai)
        {
            switch (indeksNilai)
            {
                case 'A': return 4.0m;
                case 'B': return 3.0m;
                case 'C': return 2.0m;
                case 'D': return 1.0m;
                case 'E': return 0.0m;
                default: return 0.0m;
            }
        }

        // Button 'Simpan' click event handler
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayIP();

            // Get values to be saved
            string idTrsKRS = txtidTrsKrs.Text;
            int semester = int.Parse(cbSemester.SelectedItem.ToString());
            DateTime tanggalPengisian = DateTime.Now;
            string nim = cbMahasiswa.SelectedValue.ToString();
            string idTKN = cbTendik.SelectedValue.ToString();
            string idProdi = cbProdi.SelectedValue.ToString();
            decimal ip = decimal.Parse(txtIP.Text);

            // Save to TransaksiKRS table
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertTransaksiKRS", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_TrsKRS", idTrsKRS);
                cmd.Parameters.AddWithValue("@Semester", semester);
                cmd.Parameters.AddWithValue("@Tanggal_Pengisian", tanggalPengisian);
                cmd.Parameters.AddWithValue("@NIM", nim);
                cmd.Parameters.AddWithValue("@Id_TKN", idTKN);
                cmd.Parameters.AddWithValue("@Id_Prodi", idProdi);
                cmd.Parameters.AddWithValue("@IP", ip);

                cmd.ExecuteNonQuery();

                // Save to DetailMatkul table
                foreach (DataGridViewRow row in dtgDetailMatkul.Rows)
                {
                    if (row.Cells[0].Value != null) // Make sure there is a course entered
                    {
                        //string idDetMatkul = AutoidDetMatkul();
                        string nilaiTugas = row.Cells[1].Value.ToString();
                        string nilaiQuiz = row.Cells[2].Value.ToString();
                        string nilaiUTS = row.Cells[3].Value.ToString();
                        string nilaiUAS = row.Cells[4].Value.ToString();
                        string nilaiProjek = row.Cells[5].Value.ToString();
                        string nilaiAkhir = row.Cells[6].Value.ToString();
                        string indeksNilai = row.Cells[7].Value.ToString();
                        string idMatkul = row.Cells[0].Value.ToString();

                        using (SqlConnection connection2 = new SqlConnection(connectionString))
                        {
                            connection2.Open();
                            SqlCommand cmd2 = new SqlCommand("sp_InsertDetailMatkul", connection2);
                            cmd2.CommandType = CommandType.StoredProcedure;

                            string idDetMatkul = AutoidDetMatkul(); // Dapatkan ID yang dihasilkan secara otomatis
                            cmd2.Parameters.AddWithValue("@Id_DetMatkul", idDetMatkul); // Tambahkan parameter
                            cmd2.Parameters.AddWithValue("@Nilai_Tugas", nilaiTugas);
                            cmd2.Parameters.AddWithValue("@Nilai_Quiz", nilaiQuiz);
                            cmd2.Parameters.AddWithValue("@Nilai_UTS", nilaiUTS);
                            cmd2.Parameters.AddWithValue("@Nilai_UAS", nilaiUAS);
                            cmd2.Parameters.AddWithValue("@Nilai_Projek", nilaiProjek);
                            cmd2.Parameters.AddWithValue("@Id_Matkul", idMatkul);
                            cmd2.Parameters.AddWithValue("@Id_TrsKRS", idTrsKRS);

                            cmd2.ExecuteNonQuery();
                        }
                    }
                }

                // Show success message and reset form
                MessageBox.Show("Data berhasil di simpan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoidKRS();
                dtgDetailMatkul.Rows.Clear();
                this.transaksiKRSTableAdapter.Fill(this.fINDSMART_MABRESDataSet1.TransaksiKRS);

            }
        }

        private void cbProdi_Leave(object sender, EventArgs e)
        {
            string IdMahasiswa = cbProdi.SelectedValue.ToString();
            string semester = cbSemester.SelectedItem.ToString();
            // Query dan binding untuk cbPajak
            string query = "SELECT NIM, Nama FROM Mahasiswa WHERE Id_Prodi=@D";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            // Menambahkan nilai parameter @D
            cmd.Parameters.AddWithValue("@D", IdMahasiswa); // ganti nilaiParameterD dengan nilai yang sesuai

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbMahasiswa.DisplayMember = "Nama";
            cbMahasiswa.ValueMember = "NIM";
            cbMahasiswa.DataSource = dt;

            // Query dan binding untuk cbPajak
            string query1 = "SELECT Id_Matkul, Nama FROM MataKuliah WHERE Id_Prodi=@M AND Semester=@S";
            SqlCommand cmd1 = new SqlCommand(query1, connection);

            // Menambahkan nilai parameter @D
            cmd1.Parameters.AddWithValue("@M", IdMahasiswa); // ganti nilaiParameterD dengan nilai yang sesuai
            cmd1.Parameters.AddWithValue("@S", semester);
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);

            cbMatkul.DisplayMember = "Nama";
            cbMatkul.ValueMember = "Id_Matkul";
            cbMatkul.DataSource = dt1;
        }

        private void txtNilaiProjek_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal nilaiTugas = decimal.Parse(txtNilaiTugas.Text);
                decimal nilaiQuiz = decimal.Parse(txtNilaiQuiz.Text);
                decimal nilaiUTS = decimal.Parse(txtNilaiUTS.Text);
                decimal nilaiUAS = decimal.Parse(txtNilaiUAS.Text);
                decimal nilaiProjek = decimal.Parse(txtNilaiProjek.Text);

                decimal nilaiAkhir = (nilaiTugas + nilaiQuiz + nilaiUTS + nilaiUAS + nilaiProjek) / 5.0m;

                char indeksNilai;
                if (nilaiAkhir >= 85)
                    indeksNilai = 'A';
                else if (nilaiAkhir >= 70)
                    indeksNilai = 'B';
                else if (nilaiAkhir >= 60)
                    indeksNilai = 'C';
                else if (nilaiAkhir >= 40)
                    indeksNilai = 'D';
                else
                    indeksNilai = 'E';

                // Set the Text properties of the TextBoxes
                txtNilaiAkhir.Text = nilaiAkhir.ToString("F2"); // Format the nilaiAkhir to 2 decimal places
                txtIndeksNilai.Text = indeksNilai.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid decimal numbers in all fields.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is too large or too small.");
            }

        }

        private void txtNilaiProjek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNilaiUAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNilaiUTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNilaiQuiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNilaiTugas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Hanya boleh diisi dengan angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}