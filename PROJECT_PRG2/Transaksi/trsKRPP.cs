using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.Transaksi
{
    public partial class trsKRPP : Form
    {
        string connectionString = "integrated security=true; data source=.;initial catalog=FINDSMART_MABRES";

        public trsKRPP()
        {
            InitializeComponent();
            AutoidKRPP();

        }

        public string AutoidKRPP()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM TransaksiPengajuanKRPP";

                // Execute count query
                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;
                    string newID = "KRPP" + count.ToString("000");
                    txtIdKRPP.Text = newID;
                    return newID;
                }
            }
        }

        private void trsKRPP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.PosisiPrestasi' table. You can move, or remove it, as needed.
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.PosisiPrestasi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.JenisPrestasi' table. You can move, or remove it, as needed.
            this.jenisPrestasiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.JenisPrestasi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.fINDSMART_MABRESDsAll.Mahasiswa);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TenagaKependidikan' table. You can move, or remove it, as needed.
            this.tenagaKependidikanTableAdapter.Fill(this.fINDSMART_MABRESDsAll.TenagaKependidikan);
            // Mengaitkan event handler SelectedIndexChanged dengan cbJepres
            cbJepres.SelectedIndexChanged += new EventHandler(cbJepres_SelectedIndexChanged);
    }


        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
            SqlConnection connection = new SqlConnection(connectionString);


            SqlCommand insert = new SqlCommand("sp_InsertKRPP", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("Id_TransKRPP", txtIdKRPP.Text);
            insert.Parameters.AddWithValue("Nama_Prestasi", txtnamaPrestasi.Text);
            insert.Parameters.AddWithValue("Uraian_Singkat", txtUraian.Text);
            insert.Parameters.AddWithValue("Lembaga_Pelaksana", txtLembagaPelaksana.Text);
            insert.Parameters.AddWithValue("Tanggal_Prestasi", tglPrestasi.Value);
            insert.Parameters.AddWithValue("Tanggal_Pengisian", tglPengisian.Value);
            insert.Parameters.AddWithValue("Point", txtPoint.Text);
            insert.Parameters.AddWithValue("NIM", cbMahasiswa.SelectedValue);
            insert.Parameters.AddWithValue("Id_TKN", cbTendik.SelectedValue);
            insert.Parameters.AddWithValue("Id_JenisPrestasi", cbJepres.SelectedValue);
            insert.Parameters.AddWithValue("Id_PosisiPrestasi", cbPospres.SelectedValue);
            insert.Parameters.AddWithValue("Id_Prodi", cbProdi.SelectedValue);


            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal untuk disimpan: " + ex.Message);
            }
        }

        private void cbJepres_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ambil nilai Point dari JenisPrestasi yang dipilih
            if (cbJepres.SelectedValue != null)
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                string query = "SELECT Point FROM JenisPrestasi WHERE Id_JenisPrestasi = @Id_JenisPrestasi";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id_JenisPrestasi", cbJepres.SelectedValue.ToString());

                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtPoint.Text = result.ToString();
                        }
                        else
                        {
                            txtPoint.Text = "";
                        }
                    }
                }
            }
        }


        private void clear()
        {
            txtIdKRPP.Text = "";
            txtnamaPrestasi.Text = "";
            txtLembagaPelaksana.Text = "";
            txtPoint.Text = "";
            txtUraian.Text = "";
            cbTendik.Text = "";
            cbProdi.Text = "";
            cbPospres.Text = "";
            cbMahasiswa.Text = "";
            cbJepres.Text = "";
            tglPengisian.Text = "";
            tglPrestasi.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
