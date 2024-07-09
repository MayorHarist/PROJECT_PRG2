using PROJECT_PRG2.CRUD_JenisPrestasi;
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
    public partial class trsKRPP : Form
    {
        public trsKRPP()
        {
            InitializeComponent();
        }

        private void trsKRPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TransaksiPengajuanKRPP' table. You can move, or remove it, as needed.
            this.transaksiPengajuanKRPPTableAdapter.Fill(this.fINDSMART_MABRESDsAll.TransaksiPengajuanKRPP);

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form InputJepres
            KRPP krpp = new KRPP();

            // Menampilkan form InputJepres
            krpp.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TransaksiPengajuanKRPP' table. You can move, or remove it, as needed.
            this.transaksiPengajuanKRPPTableAdapter.Fill(this.fINDSMART_MABRESDsAll.TransaksiPengajuanKRPP);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    using (SqlCommand myCommand = new SqlCommand("sp_CariKRPP", connection))
                    {
                        myCommand.CommandType = CommandType.StoredProcedure;
                        myCommand.Parameters.AddWithValue("@Cari", string.IsNullOrEmpty(txtCari.Text) ? (object)DBNull.Value : txtCari.Text);

                        using (SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand))
                        {
                            myAdapter.Fill(dataTable);
                        }
                    }

                    // Menampilkan hasil pencarian ke DataGridView
                    dgKRPP.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
