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

namespace PROJECT_PRG2.CRUD_Tendik
{
    public partial class DataTendik : Form
    {
        public DataTendik()
        {
            InitializeComponent();
            autoid();
        }

        private void DataTendik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tendik.TenagaKependidikan' table. You can move, or remove it, as needed.
           
        }

        private void btnTambahTendik_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand insert = new SqlCommand("sp_InsertTendik", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("@Id_TKN", txtIDTendik.Text);
            insert.Parameters.AddWithValue("@Tendik", txtNamaTendik.Text);
            insert.Parameters.AddWithValue("@Tanggal_Lahir", tglLahirTendik.Value);
            // Tentukan nilai jenis kelamin berdasarkan radio button yang dipilih
            string jenisKelamin = rbLaki.Checked ? "Laki-Laki" : rbPuan.Checked ? "Perempuan" : string.Empty;
            insert.Parameters.AddWithValue("@Jenis_Kelamin", jenisKelamin);
            insert.Parameters.AddWithValue("@Alamat", txtAlmatTendik.Text);
            insert.Parameters.AddWithValue("@Email", txtEmailTendik.Text);
            insert.Parameters.AddWithValue("@Telepon", TelpTendik.Text);
            insert.Parameters.AddWithValue("@Username", userNmTendik.Text);
            insert.Parameters.AddWithValue("@Password", txtPassTendik.Text);
            insert.Parameters.AddWithValue("@Status", txtStatusTendik.Text);



            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }
        }

        private void clear()
        {
            txtIDTendik.Text = "";
            txtNamaTendik.Text = "";
            tglLahirTendik.Value = DateTime.Now;
            rbLaki.Checked = false;
            rbPuan.Checked = false;
            txtAlmatTendik.Text = "";
            txtEmailTendik.Text = "";
            TelpTendik.Text = "";
            userNmTendik.Text = "";
            txtPassTendik.Text = "";
            txtStatusTendik.Text = "";
        }

        public string autoid()
        {
            string connectionstring = "integrated security=false; data source=.; user=sa; password=polman; initial catalog=FINDSMART";
            SqlConnection connection = new SqlConnection(connectionstring);
            {
                connection.Open();
                string countQuery = "SELECT COUNT(*) FROM TenagaKependidikan";

                using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                {
                    int count = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                    string newID = "TKN" + count.ToString("000");

                    txtIDTendik.Text = newID;
                    return newID;
                }
            }
        }

        private void btnBatalTendik_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void btnTampilTendik_Click(object sender, EventArgs e)
        {
            this.tenagaKependidikanTableAdapter.Fill(this.tendik.TenagaKependidikan);
        }


        private void txtNamaTendik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Masukkan hanya berupa huruf!");
            }
        }
        private void TelpTendik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Masukkan hanya berupa Angka !");
            }
        }


































        private void tenagaKependidikanBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tenagaKependidikanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvTendik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
