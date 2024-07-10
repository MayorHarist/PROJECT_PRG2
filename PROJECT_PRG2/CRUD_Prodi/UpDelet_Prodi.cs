﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Prodi
{
    public partial class UpDelet_Prodi : Form
    { 

        public UpDelet_Prodi()
        {

            InitializeComponent();
            
        }

        private void UpDelet_Prodi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDsAll.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter1.Fill(this.fINDSMART_MABRESDsAll.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet7.ProgramStudi' table. You can move, or remove it, as needed.
            //this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.ProgramStudi' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fINDSMARTDataSet3.ProgramStudi' table. You can move, or remove it, as needed.



        }
        private void clear()
        {
            txtCari.Text = "";
            txtIdProdi.Text = "";
            txtNama.Text = "";
            txtJenjangPendidikan.Text = "";
            txtAkreditasi.Text = "";
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                //string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                /*SqlCommand delete = new SqlCommand("sp_DeleteProdi", connection);
                delete.CommandType = CommandType.StoredProcedure;

                delete.Parameters.AddWithValue("@Id_Prodi", txtIdProdi.Text);

                delete.ExecuteNonQuery();*/


                SqlCommand delete = new SqlCommand("DELETE FROM ProgramStudi WHERE Id_Prodi = @Id_Prodi", connection);
                delete.Parameters.AddWithValue("@Id_Prodi", txtIdProdi.Text);
                delete.ExecuteNonQuery();


                MessageBox.Show("Data berhasil dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
                // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
                this.programStudiTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Input_Prodi input_Prodi = new Input_Prodi();
            input_Prodi.Show();
            
        }


        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //string connectionstring = "integrated security=true; data source=.; initial catalog=FINDSMART";
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand update = new SqlCommand("sp_UpdateProdi", connection);
                    update.CommandType = CommandType.StoredProcedure;

                    update.Parameters.AddWithValue("@Id_Prodi", txtIdProdi.Text);
                    update.Parameters.AddWithValue("@Nama", txtNama.Text);
                    update.Parameters.AddWithValue("@Jenjang_Pendidikan", txtJenjangPendidikan.Text);
                    update.Parameters.AddWithValue("@Akreditasi", txtAkreditasi.Text);
                    // Eksekusi stored procedure
                    update.ExecuteNonQuery();

                    // Menampilkan pesan jika eksekusi berhasil
                    MessageBox.Show("Basisdata berhasil diperbaharui", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet7.ProgramStudi);
                    // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
                    this.programStudiTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCari.Text))
                {
                    MessageBox.Show("Data ID harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART";
                string connectionString = "integrated security=true; data source=.; initial catalog=FINDSMART_MABRES";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM ProgramStudi WHERE Id_Prodi=@Id_Prodi", connection);
                    myCommand.Parameters.AddWithValue("@Id_Prodi", txtCari.Text);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        txtIdProdi.Text = dataTable.Rows[0]["Id_Prodi"].ToString();
                        txtNama.Text = dataTable.Rows[0]["Nama"].ToString();
                        txtJenjangPendidikan.Text = dataTable.Rows[0]["Jenjang_Pendidikan"].ToString();
                        txtAkreditasi.Text = dataTable.Rows[0]["Akreditasi"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("ID Prodi tidak ditemukan di dalam database.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMART_MABRESDataSet1.ProgramStudi' table. You can move, or remove it, as needed.
            this.programStudiTableAdapter2.Fill(this.fINDSMART_MABRESDataSet1.ProgramStudi);
        }

        private void txtAkreditasi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNama_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tidak boleh mengandung angka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
