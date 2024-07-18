﻿using Microsoft.ReportingServices.Diagnostics.Internal;
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

namespace PROJECT_PRG2.CRUD_Pengumuman
{
    public partial class UpdatePengumuman : Form
    {
        private object tooltipCari;

        public UpdatePengumuman()
        {
            InitializeComponent();
        }

        private void UpdatePengumuman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Pengumuman' table. You can move, or remove it, as needed.
            this.pengumumanTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.Pengumuman);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Pengumuman' table. You can move, or remove it, as needed.
            //this.pengumumanTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.Pengumuman);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter.Fill(this.fINDSMARTDataSet7.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.Pengumuman' table. You can move, or remove it, as needed.
            //this.pengumumanTableAdapter.Fill(this.fINDSMARTDataSet7.Pengumuman);
            tglPengumuman.Value = DateTime.Now;

        }

        private void clear()
        {
            txtIDPM.Text = "";
            txtCariPM.Text = "";
            txtPengumuman.Text = "";
            tglPengumuman.Value = DateTime.Now;
            txtDeskripsi.Text = "";
           
            txtTendik.Text = "";
        }
        private void txtPengumuman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCari__Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCariPM.Text))
                {
                    MessageBox.Show("Data ID harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM Pengumuman WHERE Id_Pengumuman=@Id_Pengumuman", connection);
                    myCommand.Parameters.AddWithValue("@Id_Pengumuman", txtCariPM.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIDPM.Text = dataTable.Rows[0]["Id_Pengumuman"].ToString();
                        txtPengumuman.Text = dataTable.Rows[0]["Nama"].ToString();

                        // Convert Tanggal_Lahir to DateTime
                        DateTime tanggalpengumuman;
                        if (DateTime.TryParse(dataTable.Rows[0]["Tanggal"].ToString(), out tanggalpengumuman))
                        {
                            tglPengumuman.Value = tanggalpengumuman;
                        }

                        txtDeskripsi.Text = dataTable.Rows[0]["Deskripsi"].ToString();
                        string idTKN = dataTable.Rows[0]["Id_TKN"].ToString();

                        // Retrieve the name of TenagaKependidikan using the Id_TKN
                        SqlCommand nameCommand = new SqlCommand("SELECT Nama FROM TenagaKependidikan WHERE Id_TKN=@Id_TKN", connection);
                        nameCommand.Parameters.AddWithValue("@Id_TKN", idTKN);
                        object result = nameCommand.ExecuteScalar();

                        if (result != null)
                        {
                            txtTendik.Text = result.ToString(); // Display the name in txtTendik
                        }
                        else
                        {
                            txtTendik.Text = "Nama tidak ditemukan";
                        }
                    }
                    else
                    {
                        // Menampilkan pesan jika data tidak ditemukan
                        MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambahPengumuman_Click(object sender, EventArgs e)
        {
            Pengumuman pengumuman = new Pengumuman();
            pengumuman.Show();

            // Menambahkan tooltip untuk ImageButton
            toolTip1.SetToolTip(btnTambahPengumuman, "Tambah Data");
        }

        private void btnUpPengumuman_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve the Id_TKN based on the name in txtTendik
                    SqlCommand getIdTKNCommand = new SqlCommand("SELECT Id_TKN FROM TenagaKependidikan WHERE Nama=@Nama", connection);
                    getIdTKNCommand.Parameters.AddWithValue("@Nama", txtTendik.Text);
                    object result = getIdTKNCommand.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("TenagaKependidikan tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string idTKN = result.ToString();

                    SqlCommand update = new SqlCommand("sp_UpdatePengumuman", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    // Tambahkan parameter sesuai dengan input dari form
                    update.Parameters.AddWithValue("@Id_Pengumuman", txtIDPM.Text);
                    update.Parameters.AddWithValue("@Nama", txtPengumuman.Text);
                    update.Parameters.AddWithValue("@Tanggal", tglPengumuman.Value);
                    update.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text);
                    update.Parameters.AddWithValue("@Id_TKN", idTKN); // Use the retrieved Id_TKN

                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Pengumuman' table. You can move, or remove it, as needed.
                    this.pengumumanTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.Pengumuman);
                    clear();

                    // Menambahkan tooltip untuk ImageButton
                    tooltipupdate.SetToolTip(btnTambahPengumuman, "Perbarui Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHapusPM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //string connectionString = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
                    string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    /*SqlCommand delete = new SqlCommand("sp_DeletePengumuman", connection);
                    delete.CommandType = CommandType.StoredProcedure;

                    delete.Parameters.AddWithValue("@Id_Pengumuman", txtCariPM.Text);
                    //delete.Parameters.AddWithValue("@Status", "Tidak Aktif");

                    delete.ExecuteNonQuery();*/

                    SqlCommand delete = new SqlCommand("DELETE FROM Pengumuman WHERE Id_Pengumuman = @Id_Pengumuman", connection);
                    delete.Parameters.AddWithValue("@Id_Pengumuman", txtIDPM.Text);
                    delete.ExecuteNonQuery();



                    MessageBox.Show("Data berhasil dihapus", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                    // Menambahkan tooltip untuk ImageButton
                    tooltipHapus.SetToolTip(btnTambahPengumuman, "Hapus Data");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            //this.pengumumanTableAdapter.Fill(this.fINDSMARTDataSet7.Pengumuman);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.Pengumuman' table. You can move, or remove it, as needed.
            //this.pengumumanTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.Pengumuman);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.TenagaKependidikan' table. You can move, or remove it, as needed.
            //this.tenagaKependidikanTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.TenagaKependidikan);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.Pengumuman' table. You can move, or remove it, as needed.
            this.pengumumanTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.Pengumuman);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void txtTendik_Click(object sender, EventArgs e)
        {
            string idTKN = LoginSbgTenDik.LoggedInId;

            if (string.IsNullOrEmpty(idTKN))
            {
                MessageBox.Show("ID TenagaKependidikan tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";

            string query = "SELECT Nama FROM TenagaKependidikan WHERE Id_TKN = @Id_TKN";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_TKN", idTKN);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string namaTendik = result.ToString();
                            txtTendik.Text = namaTendik; // Display the name in the TextBox (or any other appropriate control)
                                                         // Save the idTKN as needed
                        }
                        else
                        {
                            MessageBox.Show("TenagaKependidikan tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}