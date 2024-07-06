using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.Transaksi
{
    public partial class trsKRS : Form
    {
        public trsKRS()
        {
            InitializeComponent();
            buatkolom();
            AutoidKRS();

            
        }
        string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART";

        private void trsKRS_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.MataKuliah' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.fINDSMARTDataSet7.Mahasiswa);

        }
        public string AutoidKRS()
        {
            string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM TransaksiKRS";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "KRS" + count.ToString("000");

                    // Assuming you have a TextBox named txtIdTransKRS to display the new ID
                    txtidTrsKrs.Text = newID;

                    return newID;
                }
            }
        }
        public string AutoidDetMatkul()
        {
            string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM DetailMatkul";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "DET" + count.ToString("000");

                    return newID;
                }
            }
        }


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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan semua kotak teks diisi
                if (string.IsNullOrWhiteSpace(txtNilaiTugas.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiQuiz.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiUTS.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiUAS.Text) ||
                    string.IsNullOrWhiteSpace(txtNilaiProjek.Text))
                {
                    MessageBox.Show("Please enter values in all fields.");
                    return;
                }

                // Dapatkan mata kuliah dan semester yang dipilih
                string matkul = cbMatkul.SelectedValue.ToString();
                string semester = cbSemester.SelectedItem.ToString();

                // Buat baris baru untuk DataGridView
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgDetailMatkul);

                // Set nilai untuk setiap kolom
                row.Cells[0].Value = matkul;
                row.Cells[1].Value = txtNilaiTugas.Text;
                row.Cells[2].Value = txtNilaiQuiz.Text;
                row.Cells[3].Value = txtNilaiUTS.Text;
                row.Cells[4].Value = txtNilaiUAS.Text;
                row.Cells[5].Value = txtNilaiProjek.Text;

                // Hitung Nilai Akhir dan Indeks Nilai
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

                row.Cells[6].Value = nilaiAkhir.ToString("N2"); // Nilai Akhir
                row.Cells[7].Value = indeksNilai.ToString(); // Indeks Nilai

                // Tambahkan baris ke DataGridView
                dtgDetailMatkul.Rows.Add(row);

                // Hitung dan tampilkan IP di TextBox
                CalculateAndDisplayIP();
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

        private void CalculateAndDisplayIP()
        {
            decimal totalNilaiAkhir = 0;
            int jumlahMatkul = 0;

            foreach (DataGridViewRow row in dtgDetailMatkul.Rows)
            {
                if (row.Cells[6].Value != null) // Pastikan nilai akhir ada
                {
                    totalNilaiAkhir += decimal.Parse(row.Cells[6].Value.ToString());
                    jumlahMatkul++;
                }
            }

            decimal ip = jumlahMatkul > 0 ? totalNilaiAkhir / jumlahMatkul : 0;
            txtIP.Text = ip.ToString("N2");
        }



        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Hitung total nilai akhir dan jumlah mata kuliah
            decimal totalNilaiAkhir = 0;
            int jumlahMatkul = 0;

            foreach (DataGridViewRow row in dtgDetailMatkul.Rows)
            {
                if (row.Cells[6].Value != null) // Pastikan nilai akhir ada
                {
                    totalNilaiAkhir += decimal.Parse(row.Cells[6].Value.ToString());
                    jumlahMatkul++;
                }
            }

            // Hitung IP
            decimal ip = jumlahMatkul > 0 ? totalNilaiAkhir / jumlahMatkul : 0;
            txtIP.Text = ip.ToString("N2");

            // Get the values for the TransaksiKRS table
            string idTrsKRS = txtidTrsKrs.Text;
            int semester = int.Parse(cbSemester.SelectedItem.ToString());
            DateTime tanggalPengisian = DateTime.Now; // use current date and time
            string nim = cbMahasiswa.SelectedValue.ToString(); // get selected NIM from combobox
            string idTKN = cbTendik.SelectedValue.ToString(); // get selected Id_TKN from combobox
            string idProdi = cbProdi.SelectedValue.ToString(); // get selected Id_Prodi from combobox

            // Call the stored procedure for TransaksiKRS
            string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_InsertTransaksiKRS", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_TrsKRS", idTrsKRS);
                command.Parameters.AddWithValue("@Semester", semester);
                command.Parameters.AddWithValue("@Tanggal_Pengisian", tanggalPengisian);
                command.Parameters.AddWithValue("@IP", ip);
                command.Parameters.AddWithValue("@Id_Prodi", idProdi);
                command.Parameters.AddWithValue("@NIM", nim);
                command.Parameters.AddWithValue("@Id_TKN", idTKN);

                command.ExecuteNonQuery();
            }

            // Now, loop through each row in the DataGridView and call the sp_InsertDetailMatkul stored procedure
            foreach (DataGridViewRow row in dtgDetailMatkul.Rows)
            {
                if (row.Cells[0].Value != null) // Pastikan ada mata kuliah yang diinput
                {
                    // Get the values for each column
                    string idDetMatkul = AutoidDetMatkul();
                    string nilaiTugas = row.Cells[1].Value.ToString();
                    string nilaiQuiz = row.Cells[2].Value.ToString();
                    string nilaiUTS = row.Cells[3].Value.ToString();
                    string nilaiUAS = row.Cells[4].Value.ToString();
                    string nilaiProjek = row.Cells[5].Value.ToString();
                    string idMatkul = row.Cells[0].Value.ToString();

                    // Call the sp_InsertDetailMatkul stored procedure
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("sp_InsertDetailMatkul", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Id_DetMatkul", idDetMatkul);
                        command.Parameters.AddWithValue("@Nilai_Tugas", nilaiTugas);
                        command.Parameters.AddWithValue("@Nilai_Quiz", nilaiQuiz);
                        command.Parameters.AddWithValue("@Nilai_UTS", nilaiUTS);
                        command.Parameters.AddWithValue("@Nilai_UAS", nilaiUAS);
                        command.Parameters.AddWithValue("@Nilai_Projek", nilaiProjek);
                        command.Parameters.AddWithValue("@Id_Matkul", idMatkul);
                        command.Parameters.AddWithValue("@Id_TrsKRS", idTrsKRS);

                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Data berhasil disimpan!");
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

        private void txtNilaiProjek_Leave_1(object sender, EventArgs e)
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
    }
}
