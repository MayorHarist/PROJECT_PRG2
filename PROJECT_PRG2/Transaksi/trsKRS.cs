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


        }
    }
}
