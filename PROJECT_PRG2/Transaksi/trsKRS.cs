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
                string matkul = cbMatkul.SelectedValue.ToString();
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
            string idTrsKRS = txtidTrsKrs.Text;
            int semester = int.Parse(cbSemester.SelectedItem.ToString());
            DateTime tanggalPengisian = DateTime.Now; // use current date and time
            decimal ip = decimal.Parse(txtIP.Text);
            string nim = cbMahasiswa.SelectedItem.ToString(); // get selected NIM from combobox
            string idTKN = cbTendik.SelectedItem.ToString(); // get selected Id_TKN from combobox

            // Call the stored procedure
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

            MessageBox.Show("Data berhasil disimpan!");
        }

        private void cbProdi_Leave(object sender, EventArgs e)
        {
            string IdMahasiswa = cbProdi.SelectedValue.ToString();
            string semester = cbSemester.SelectedItem.ToString();
            // Query dan binding untuk cbPajak
            string query = "SELECT Id_Prodi, Nama FROM Mahasiswa WHERE Id_Prodi=@D";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            // Menambahkan nilai parameter @D
            cmd.Parameters.AddWithValue("@D", IdMahasiswa); // ganti nilaiParameterD dengan nilai yang sesuai

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbMahasiswa.DisplayMember = "Nama";
            cbMahasiswa.ValueMember = "Id_Mahasiswa";
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
    }
}
