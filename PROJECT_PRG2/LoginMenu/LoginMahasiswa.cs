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

namespace PROJECT_PRG2
{
    public partial class LoginMahasiswa : Form
    {
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private IContainer components;
        private Guna.UI2.WinForms.Guna2Button btnMasuk;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private Guna.UI2.WinForms.Guna2TextBox txtSandi;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private string connectionString = "integrated security=true; data source =.; initial catalog=FINDSMART";
        public LoginMahasiswa()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Ambil input dari pengguna
            string username = txtUsername.Text.Trim();
            string password = txtSandi.Text.Trim();

            // Validasi input kosong
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nama pengguna tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kata sandi tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi panjang input (misal, maksimum 50 karakter)
            if (username.Length > 50)
            {
                MessageBox.Show("Nama pengguna terlalu panjang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length > 50)
            {
                MessageBox.Show("Kata sandi terlalu panjang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL Query untuk memverifikasi username dan password
            string query = "SELECT COUNT(1) FROM Mahasiswa WHERE Username=@Username AND Password=@Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Tambahkan parameter untuk query
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        // Buka koneksi ke database
                        conn.Open();

                        // Eksekusi query dan ambil hasil
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Anda dapat membuka form baru di sini atau mengarahkan pengguna ke bagian lain dari aplikasi Anda
                            DasboardTendik dasboardTendik = new DasboardTendik();
                            dasboardTendik.Show();
                            this.Hide(); // Sembunyikan form login saat form kedua dibuka
                        }
                        else
                        {
                            MessageBox.Show("Nama Pengguna dan Kata Sandi salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnMasuk = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.txtSandi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnMasuk
            // 
            this.btnMasuk.Animated = true;
            this.btnMasuk.AutoRoundedCorners = true;
            this.btnMasuk.BackColor = System.Drawing.Color.Transparent;
            this.btnMasuk.BorderColor = System.Drawing.Color.Transparent;
            this.btnMasuk.BorderRadius = 29;
            this.btnMasuk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMasuk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMasuk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMasuk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMasuk.FillColor = System.Drawing.Color.Transparent;
            this.btnMasuk.FocusedColor = System.Drawing.Color.White;
            this.btnMasuk.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Location = new System.Drawing.Point(113, 581);
            this.btnMasuk.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(511, 61);
            this.btnMasuk.TabIndex = 19;
            this.btnMasuk.UseTransparentBackground = true;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Animated = true;
            this.btnKembali.AutoRoundedCorners = true;
            this.btnKembali.BackColor = System.Drawing.Color.Transparent;
            this.btnKembali.BorderRadius = 30;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.Color.Transparent;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(113, 674);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(511, 62);
            this.btnKembali.TabIndex = 18;
            this.btnKembali.UseTransparentBackground = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // txtSandi
            // 
            this.txtSandi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSandi.BorderColor = System.Drawing.Color.Transparent;
            this.txtSandi.BorderThickness = 0;
            this.txtSandi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSandi.DefaultText = "";
            this.txtSandi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSandi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSandi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSandi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSandi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.txtSandi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSandi.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtSandi.ForeColor = System.Drawing.Color.White;
            this.txtSandi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSandi.Location = new System.Drawing.Point(121, 486);
            this.txtSandi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSandi.Name = "txtSandi";
            this.txtSandi.PasswordChar = '*';
            this.txtSandi.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSandi.PlaceholderText = "Masukkan Sandi";
            this.txtSandi.SelectedText = "";
            this.txtSandi.Size = new System.Drawing.Size(478, 43);
            this.txtSandi.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtUsername.BorderThickness = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(121, 387);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsername.PlaceholderText = "Masukkan Nama Pengguna";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(478, 45);
            this.txtUsername.TabIndex = 16;
            // 
            // LoginMahasiswa
            // 
            this.BackgroundImage = global::PROJECT_PRG2.Properties.Resources.LoginMhs;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtSandi);
            this.Controls.Add(this.txtUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginMahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
