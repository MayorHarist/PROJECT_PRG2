namespace PROJECT_PRG2.CRUD_Mahasiswa
{
    partial class UpDeletMahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpDeletMahasiswa));
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNIM = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.programStudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fINDSMARTDataSet7 = new PROJECT_PRG2.FINDSMARTDataSet7();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimeTanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelepon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbPerempuan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLaki = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTahunMasuk = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.MahasiswaTableAdapter();
            this.programStudiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHapus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTambahMhs = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari_ = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 722);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 211;
            this.label3.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Animated = true;
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.BorderColor = System.Drawing.Color.Black;
            this.txtNama.BorderRadius = 10;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.Enabled = false;
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(209, 735);
            this.txtNama.Margin = new System.Windows.Forms.Padding(5);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(191, 31);
            this.txtNama.TabIndex = 201;
            // 
            // txtNIM
            // 
            this.txtNIM.Animated = true;
            this.txtNIM.BackColor = System.Drawing.Color.Transparent;
            this.txtNIM.BorderColor = System.Drawing.Color.Black;
            this.txtNIM.BorderRadius = 10;
            this.txtNIM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIM.DefaultText = "";
            this.txtNIM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNIM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNIM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNIM.ForeColor = System.Drawing.Color.Black;
            this.txtNIM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIM.Location = new System.Drawing.Point(547, 165);
            this.txtNIM.Margin = new System.Windows.Forms.Padding(5);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.PasswordChar = '\0';
            this.txtNIM.PlaceholderText = "";
            this.txtNIM.SelectedText = "";
            this.txtNIM.Size = new System.Drawing.Size(181, 31);
            this.txtNIM.TabIndex = 200;
            // 
            // cbProdi
            // 
            this.cbProdi.DataSource = this.programStudiBindingSource;
            this.cbProdi.DisplayMember = "Nama";
            this.cbProdi.Enabled = false;
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.ItemHeight = 13;
            this.cbProdi.Location = new System.Drawing.Point(209, 661);
            this.cbProdi.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(192, 21);
            this.cbProdi.TabIndex = 218;
            this.cbProdi.ValueMember = "Id_Prodi";
            // 
            // programStudiBindingSource
            // 
            this.programStudiBindingSource.DataMember = "ProgramStudi";
            this.programStudiBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // fINDSMARTDataSet7
            // 
            this.fINDSMARTDataSet7.DataSetName = "FINDSMARTDataSet7";
            this.fINDSMARTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(216, 639);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 217;
            this.label12.Text = "Id Prodi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 811);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 220;
            this.label7.Text = "Tanggal Lahir";
            // 
            // DateTimeTanggal
            // 
            this.DateTimeTanggal.Animated = true;
            this.DateTimeTanggal.AutoRoundedCorners = true;
            this.DateTimeTanggal.BackColor = System.Drawing.Color.Transparent;
            this.DateTimeTanggal.BorderRadius = 16;
            this.DateTimeTanggal.Checked = true;
            this.DateTimeTanggal.Enabled = false;
            this.DateTimeTanggal.FillColor = System.Drawing.Color.Cyan;
            this.DateTimeTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DateTimeTanggal.ForeColor = System.Drawing.Color.Black;
            this.DateTimeTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimeTanggal.Location = new System.Drawing.Point(209, 833);
            this.DateTimeTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimeTanggal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimeTanggal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimeTanggal.Name = "DateTimeTanggal";
            this.DateTimeTanggal.Size = new System.Drawing.Size(208, 34);
            this.DateTimeTanggal.TabIndex = 219;
            this.DateTimeTanggal.Value = new System.DateTime(2024, 6, 15, 22, 37, 28, 314);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(473, 735);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(192, 58);
            this.txtAlamat.TabIndex = 237;
            this.txtAlamat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(988, 648);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 236;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.Enabled = false;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(978, 661);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(190, 31);
            this.txtPassword.TabIndex = 235;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(735, 722);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 234;
            this.label9.Text = "Tahun Masuk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(735, 819);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 233;
            this.label8.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 647);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 232;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 715);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 231;
            this.label5.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 822);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 230;
            this.label4.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(735, 648);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 229;
            this.label10.Text = "Telepon";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Animated = true;
            this.txtTelepon.BackColor = System.Drawing.Color.Transparent;
            this.txtTelepon.BorderColor = System.Drawing.Color.Black;
            this.txtTelepon.BorderRadius = 10;
            this.txtTelepon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelepon.DefaultText = "";
            this.txtTelepon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelepon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelepon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelepon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelepon.Enabled = false;
            this.txtTelepon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTelepon.ForeColor = System.Drawing.Color.Black;
            this.txtTelepon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelepon.Location = new System.Drawing.Point(725, 661);
            this.txtTelepon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.PasswordChar = '\0';
            this.txtTelepon.PlaceholderText = "";
            this.txtTelepon.SelectedText = "";
            this.txtTelepon.Size = new System.Drawing.Size(190, 31);
            this.txtTelepon.TabIndex = 226;
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.Enabled = false;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(474, 836);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(190, 31);
            this.txtEmail.TabIndex = 225;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.BackColor = System.Drawing.Color.Transparent;
            this.rbPerempuan.CheckedState.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rbPerempuan.CheckedState.BorderThickness = 0;
            this.rbPerempuan.CheckedState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.rbPerempuan.CheckedState.InnerColor = System.Drawing.SystemColors.MenuHighlight;
            this.rbPerempuan.CheckedState.InnerOffset = -4;
            this.rbPerempuan.Enabled = false;
            this.rbPerempuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbPerempuan.ForeColor = System.Drawing.Color.Black;
            this.rbPerempuan.Location = new System.Drawing.Point(558, 661);
            this.rbPerempuan.Margin = new System.Windows.Forms.Padding(2);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(90, 19);
            this.rbPerempuan.TabIndex = 224;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPerempuan.UncheckedState.BorderThickness = 2;
            this.rbPerempuan.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPerempuan.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPerempuan.UseVisualStyleBackColor = false;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.BackColor = System.Drawing.Color.Transparent;
            this.rbLaki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbLaki.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLaki.CheckedState.BorderThickness = 0;
            this.rbLaki.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLaki.CheckedState.InnerColor = System.Drawing.SystemColors.MenuHighlight;
            this.rbLaki.CheckedState.InnerOffset = -4;
            this.rbLaki.Enabled = false;
            this.rbLaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbLaki.ForeColor = System.Drawing.Color.Black;
            this.rbLaki.Location = new System.Drawing.Point(473, 661);
            this.rbLaki.Margin = new System.Windows.Forms.Padding(2);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(77, 19);
            this.rbLaki.TabIndex = 223;
            this.rbLaki.Text = "Laki - laki";
            this.rbLaki.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLaki.UncheckedState.BorderThickness = 2;
            this.rbLaki.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLaki.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLaki.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.Enabled = false;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(725, 833);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(190, 31);
            this.txtUsername.TabIndex = 222;
            // 
            // txtTahunMasuk
            // 
            this.txtTahunMasuk.Animated = true;
            this.txtTahunMasuk.BackColor = System.Drawing.Color.Transparent;
            this.txtTahunMasuk.BorderColor = System.Drawing.Color.Black;
            this.txtTahunMasuk.BorderRadius = 10;
            this.txtTahunMasuk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTahunMasuk.DefaultText = "";
            this.txtTahunMasuk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTahunMasuk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTahunMasuk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahunMasuk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahunMasuk.Enabled = false;
            this.txtTahunMasuk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahunMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTahunMasuk.ForeColor = System.Drawing.Color.Black;
            this.txtTahunMasuk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahunMasuk.Location = new System.Drawing.Point(725, 735);
            this.txtTahunMasuk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTahunMasuk.Name = "txtTahunMasuk";
            this.txtTahunMasuk.PasswordChar = '\0';
            this.txtTahunMasuk.PlaceholderText = "";
            this.txtTahunMasuk.SelectedText = "";
            this.txtTahunMasuk.Size = new System.Drawing.Size(190, 31);
            this.txtTahunMasuk.TabIndex = 221;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 34;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIMDataGridViewTextBoxColumn,
            this.idProdiDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.tahunMasukDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.mahasiswaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(249, 245);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(854, 362);
            this.guna2DataGridView1.TabIndex = 238;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 34;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nIMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            // 
            // idProdiDataGridViewTextBoxColumn
            // 
            this.idProdiDataGridViewTextBoxColumn.DataPropertyName = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.HeaderText = "Id_Prodi";
            this.idProdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdiDataGridViewTextBoxColumn.Name = "idProdiDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon";
            this.teleponDataGridViewTextBoxColumn.HeaderText = "Telepon";
            this.teleponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            // 
            // tahunMasukDataGridViewTextBoxColumn
            // 
            this.tahunMasukDataGridViewTextBoxColumn.DataPropertyName = "Tahun_Masuk";
            this.tahunMasukDataGridViewTextBoxColumn.HeaderText = "Tahun_Masuk";
            this.tahunMasukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tahunMasukDataGridViewTextBoxColumn.Name = "tahunMasukDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.fINDSMARTDataSet7;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // programStudiTableAdapter
            // 
            this.programStudiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1128, 712);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 243;
            this.label2.Text = "Aksi";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnHapus.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnHapus.Image = ((System.Drawing.Image)(resources.GetObject("btnHapus.Image")));
            this.btnHapus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnHapus.ImageRotate = 0F;
            this.btnHapus.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHapus.Location = new System.Drawing.Point(1233, 735);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnHapus.Size = new System.Drawing.Size(32, 31);
            this.btnHapus.TabIndex = 241;
            this.btnHapus.UseTransparentBackground = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus__Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpdate.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.ImageRotate = 0F;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(1194, 735);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnUpdate.Size = new System.Drawing.Size(29, 31);
            this.btnUpdate.TabIndex = 240;
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambahMhs
            // 
            this.btnTambahMhs.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahMhs.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTambahMhs.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnTambahMhs.Image = ((System.Drawing.Image)(resources.GetObject("btnTambahMhs.Image")));
            this.btnTambahMhs.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTambahMhs.ImageRotate = 0F;
            this.btnTambahMhs.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTambahMhs.Location = new System.Drawing.Point(1151, 735);
            this.btnTambahMhs.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahMhs.Name = "btnTambahMhs";
            this.btnTambahMhs.PressedState.ImageSize = new System.Drawing.Size(31, 31);
            this.btnTambahMhs.Size = new System.Drawing.Size(30, 31);
            this.btnTambahMhs.TabIndex = 239;
            this.btnTambahMhs.UseTransparentBackground = true;
            this.btnTambahMhs.Click += new System.EventHandler(this.btnTambahMhs_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(1129, 732);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(145, 37);
            this.guna2TextBox1.TabIndex = 242;
            // 
            // btnCari_
            // 
            this.btnCari_.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari_.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari_.Image = global::PROJECT_PRG2.Properties.Resources.cari;
            this.btnCari_.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCari_.ImageRotate = 0F;
            this.btnCari_.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCari_.Location = new System.Drawing.Point(483, 148);
            this.btnCari_.Name = "btnCari_";
            this.btnCari_.PressedState.ImageRotate = 3F;
            this.btnCari_.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCari_.Size = new System.Drawing.Size(59, 60);
            this.btnCari_.TabIndex = 244;
            this.btnCari_.Click += new System.EventHandler(this.btnCari__Click);
            // 
            // btnBatal
            // 
            this.btnBatal.AutoRoundedCorners = true;
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderRadius = 13;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(1129, 822);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(133, 28);
            this.btnBatal.TabIndex = 245;
            this.btnBatal.Text = "Batal";
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 13;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1131, 604);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 28);
            this.btnRefresh.TabIndex = 246;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UpDeletMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 1033);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnCari_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambahMhs);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtTahunMasuk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTimeTanggal);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UpDeletMahasiswa";
            this.Text = "UpDeletMahasiswa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpDeletMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtNIM;
        private System.Windows.Forms.ComboBox cbProdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimeTanggal;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtTelepon;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2RadioButton rbPerempuan;
        private Guna.UI2.WinForms.Guna2RadioButton rbLaki;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtTahunMasuk;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private FINDSMARTDataSet7 fINDSMARTDataSet7;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private FINDSMARTDataSet7TableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource programStudiBindingSource;
        private FINDSMARTDataSet7TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton btnHapus;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdate;
        private Guna.UI2.WinForms.Guna2ImageButton btnTambahMhs;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnCari_;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}