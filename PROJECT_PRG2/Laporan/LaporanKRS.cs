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

namespace PROJECT_PRG2.Laporan
{
    public partial class LaporanKRS : Form
    {
        public LaporanKRS()
        {
            InitializeComponent();
        }

        private void KRS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.LaporanMahasiswaBerprestasi' table. You can move, or remove it, as needed.
            this.laporanMahasiswaBerprestasiTableAdapter.Fill(this.fINDSMART_MABRESDataSet1.LaporanMahasiswaBerprestasi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.LaporanMahasiswaBerprestasi' table. You can move, or remove it, as needed.
            //this.laporanMahasiswaBerprestasiTableAdapter1.Fill(this.fINDSMART_MABRESDataSet1.LaporanMahasiswaBerprestasi);
            // TODO: This line of code loads data into the 'repKRS.LaporanMahasiswaBerprestasi' table. You can move, or remove it, as needed.
            //this.laporanMahasiswaBerprestasiTableAdapter.Fill(this.repKRS.LaporanMahasiswaBerprestasi);
            BindComboBox();
            cbFilter.Text = "-- Filter KRS --";

            this.reportViewer1.RefreshReport();
        }

        private void BindComboBox()
        {
            // Menghubungkan ke database dan mengisi ComboBox
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            string query = "SELECT DISTINCT Nama_Prodi FROM LaporanMahasiswaBerprestasi";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbFilter.Items.Add(reader["Nama_Prodi"].ToString());
                        }
                    }
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load data ke ReportViewer berdasarkan filter
            LoadReportData(cbFilter.SelectedItem.ToString());
        }

        private void LoadReportData(string filter)
        {
            // Menghubungkan ke database dan mengisi ReportViewer dengan data yang difilter
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            string query = @"
            SELECT NIM, Nama_Mahasiswa, Jenis_Kelamin, Tahun_Masuk, Nama_Prodi, IPK
            FROM LaporanMahasiswaBerprestasi";

            if (!string.IsNullOrEmpty(filter))
            {
                query += " WHERE Nama_Prodi = @Nama_Prodi";
            }

            // Menambahkan klausa ORDER BY untuk mengurutkan data dari yang terbesar hingga terkecil
            query += " ORDER BY IPK DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        command.Parameters.AddWithValue("@Nama_Prodi", filter);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "LaporanMahasiswaBerprestasi");

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSet.Tables["LaporanMahasiswaBerprestasi"]));
                        reportViewer1.RefreshReport();
                    }
                }
            }
        }
    }
}
