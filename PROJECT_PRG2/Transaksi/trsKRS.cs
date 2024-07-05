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
        }

        private void trsKRS_Load(object sender, EventArgs e)
        {
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
            
                // Dapatkan mata kuliah dan semester yang dipilih
                string matkul = cbMatkul.SelectedItem.ToString();
                string semester = cbSemester.SelectedItem.ToString();

                // Buat baris baru untuk DataGridView
                DataGridViewRow row = new DataGridViewRow();

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
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Get the values for the TransaksiKRS table
            string idTrsKRS = Guid.NewGuid().ToString();
            int semester = int.Parse(cbSemester.SelectedItem.ToString());
            DateTime tanggalPengisian = DateTime.Now; // use current date and time
            decimal ip = decimal.Parse(txtIP.Text);
            string nim = cbMahasiswa.SelectedItem.ToString(); // get selected NIM from combobox
            string idTKN = cbTendik.SelectedItem.ToString(); // get selected Id_TKN from combobox

            // Call the stored procedure
            using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("InsertTransaksiKRS", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id_TrsKRS", idTrsKRS);
                command.Parameters.AddWithValue("@Semester", semester);
                command.Parameters.AddWithValue("@Tanggal_Pengisian", tanggalPengisian);
                command.Parameters.AddWithValue("@IP", ip);
                command.Parameters.AddWithValue("@NIM", nim);
                command.Parameters.AddWithValue("@Id_TKN", idTKN);

                command.ExecuteNonQuery();
            }

            // Now, loop through each row in the DataGridView and call the sp_InsertDetailMatkul stored procedure
            foreach (DataGridViewRow row in dtgDetailMatkul.Rows)
            {
                // Get the values for each column
                string idDetMatkul = Guid.NewGuid().ToString();
                string nilaiTugas = row.Cells[1].Value.ToString();
                string nilaiQuiz = row.Cells[2].Value.ToString();
                string nilaiUTS = row.Cells[3].Value.ToString();
                string nilaiUAS = row.Cells[4].Value.ToString();
                string nilaiProjek = row.Cells[5].Value.ToString();
                string idMatkul = row.Cells[0].Value.ToString();

                // Call the sp_InsertDetailMatkul stored procedure
                using (SqlConnection connection = new SqlConnection("your_connection_string_here"))
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

            MessageBox.Show("Data berhasil disimpan!");
        }
    }
}
