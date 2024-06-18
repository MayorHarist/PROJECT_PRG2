namespace PROJECT_PRG2.CRUD_MataKuliah
{
    partial class UpdateDeleteMatkul
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
            this.programStudiTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet2TableAdapters.ProgramStudiTableAdapter();
            this.fINDSMARTDataSet2 = new PROJECT_PRG2.FINDSMARTDataSet2();
            this.programStudiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProdi = new System.Windows.Forms.ComboBox();
            this.fINDSMARTDataSet1 = new PROJECT_PRG2.FINDSMARTDataSet1();
            this.dosenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPegawai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.dosenTableAdapter = new PROJECT_PRG2.FINDSMARTDataSet1TableAdapters.DosenTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.txtSemester = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtJenis = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSKS = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdMatkul = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // programStudiTableAdapter
            // 
            this.programStudiTableAdapter.ClearBeforeFill = true;
            // 
            // fINDSMARTDataSet2
            // 
            this.fINDSMARTDataSet2.DataSetName = "FINDSMARTDataSet2";
            this.fINDSMARTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programStudiBindingSource
            // 
            this.programStudiBindingSource.DataMember = "ProgramStudi";
            this.programStudiBindingSource.DataSource = this.fINDSMARTDataSet2;
            // 
            // cbProdi
            // 
            this.cbProdi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.programStudiBindingSource, "Id_Prodi", true));
            this.cbProdi.DataSource = this.programStudiBindingSource;
            this.cbProdi.DisplayMember = "Id_Prodi";
            this.cbProdi.Enabled = false;
            this.cbProdi.FormattingEnabled = true;
            this.cbProdi.ItemHeight = 20;
            this.cbProdi.Location = new System.Drawing.Point(879, 629);
            this.cbProdi.Name = "cbProdi";
            this.cbProdi.Size = new System.Drawing.Size(286, 28);
            this.cbProdi.TabIndex = 85;
            this.cbProdi.ValueMember = "Id_Prodi";
            // 
            // fINDSMARTDataSet1
            // 
            this.fINDSMARTDataSet1.DataSetName = "FINDSMARTDataSet1";
            this.fINDSMARTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dosenBindingSource
            // 
            this.dosenBindingSource.DataMember = "Dosen";
            this.dosenBindingSource.DataSource = this.fINDSMARTDataSet1;
            // 
            // cbPegawai
            // 
            this.cbPegawai.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dosenBindingSource, "No_Pegawai", true));
            this.cbPegawai.DataSource = this.dosenBindingSource;
            this.cbPegawai.DisplayMember = "No_Pegawai";
            this.cbPegawai.Enabled = false;
            this.cbPegawai.FormattingEnabled = true;
            this.cbPegawai.ItemHeight = 20;
            this.cbPegawai.Location = new System.Drawing.Point(879, 579);
            this.cbPegawai.Name = "cbPegawai";
            this.cbPegawai.Size = new System.Drawing.Size(286, 28);
            this.cbPegawai.TabIndex = 84;
            this.cbPegawai.ValueMember = "No_Pegawai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(757, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 83;
            this.label2.Text = "Id Prodi";
            // 
            // txtStatus
            // 
            this.txtStatus.Animated = true;
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BorderColor = System.Drawing.Color.Black;
            this.txtStatus.BorderRadius = 10;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.Enabled = false;
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Location = new System.Drawing.Point(879, 517);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.PlaceholderText = "";
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(286, 48);
            this.txtStatus.TabIndex = 82;
            // 
            // dosenTableAdapter
            // 
            this.dosenTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(758, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 32);
            this.label11.TabIndex = 81;
            this.label11.Text = "Nama";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(716, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 32);
            this.label10.TabIndex = 80;
            this.label10.Text = "Jumlah SKS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(767, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 32);
            this.label9.TabIndex = 79;
            this.label9.Text = "Jenis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 32);
            this.label8.TabIndex = 78;
            this.label8.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(766, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 32);
            this.label7.TabIndex = 77;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(717, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 76;
            this.label6.Text = "No Pegawai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(730, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 75;
            this.label1.Text = "Id Matkul";
            // 
            // btnUbah
            // 
            this.btnUbah.AutoRoundedCorners = true;
            this.btnUbah.BorderRadius = 26;
            this.btnUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUbah.Enabled = false;
            this.btnUbah.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUbah.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnUbah.ForeColor = System.Drawing.Color.White;
            this.btnUbah.Location = new System.Drawing.Point(752, 743);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(168, 55);
            this.btnUbah.TabIndex = 74;
            this.btnUbah.Text = "Ubah";
            // 
            // btnHapus
            // 
            this.btnHapus.AutoRoundedCorners = true;
            this.btnHapus.BorderRadius = 26;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.Enabled = false;
            this.btnHapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHapus.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(1014, 743);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(168, 55);
            this.btnHapus.TabIndex = 73;
            this.btnHapus.Text = "Hapus";
            // 
            // txtSemester
            // 
            this.txtSemester.Animated = true;
            this.txtSemester.BackColor = System.Drawing.Color.Transparent;
            this.txtSemester.BorderColor = System.Drawing.Color.Black;
            this.txtSemester.BorderRadius = 10;
            this.txtSemester.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSemester.DefaultText = "";
            this.txtSemester.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSemester.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSemester.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSemester.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSemester.Enabled = false;
            this.txtSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtSemester.ForeColor = System.Drawing.Color.Black;
            this.txtSemester.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSemester.Location = new System.Drawing.Point(879, 459);
            this.txtSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.PasswordChar = '\0';
            this.txtSemester.PlaceholderText = "";
            this.txtSemester.SelectedText = "";
            this.txtSemester.Size = new System.Drawing.Size(286, 48);
            this.txtSemester.TabIndex = 72;
            // 
            // txtJenis
            // 
            this.txtJenis.Animated = true;
            this.txtJenis.BackColor = System.Drawing.Color.Transparent;
            this.txtJenis.BorderColor = System.Drawing.Color.Black;
            this.txtJenis.BorderRadius = 10;
            this.txtJenis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJenis.DefaultText = "";
            this.txtJenis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJenis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJenis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJenis.Enabled = false;
            this.txtJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenis.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtJenis.ForeColor = System.Drawing.Color.Black;
            this.txtJenis.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJenis.Location = new System.Drawing.Point(881, 401);
            this.txtJenis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.PasswordChar = '\0';
            this.txtJenis.PlaceholderText = "";
            this.txtJenis.SelectedText = "";
            this.txtJenis.Size = new System.Drawing.Size(286, 48);
            this.txtJenis.TabIndex = 71;
            // 
            // txtSKS
            // 
            this.txtSKS.Animated = true;
            this.txtSKS.BackColor = System.Drawing.Color.Transparent;
            this.txtSKS.BorderColor = System.Drawing.Color.Black;
            this.txtSKS.BorderRadius = 10;
            this.txtSKS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSKS.DefaultText = "";
            this.txtSKS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSKS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSKS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSKS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSKS.Enabled = false;
            this.txtSKS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKS.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtSKS.ForeColor = System.Drawing.Color.Black;
            this.txtSKS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKS.Location = new System.Drawing.Point(881, 343);
            this.txtSKS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSKS.Name = "txtSKS";
            this.txtSKS.PasswordChar = '\0';
            this.txtSKS.PlaceholderText = "";
            this.txtSKS.SelectedText = "";
            this.txtSKS.Size = new System.Drawing.Size(286, 48);
            this.txtSKS.TabIndex = 70;
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
            this.txtNama.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(881, 285);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(286, 48);
            this.txtNama.TabIndex = 69;
            // 
            // txtIdMatkul
            // 
            this.txtIdMatkul.Animated = true;
            this.txtIdMatkul.BackColor = System.Drawing.Color.Transparent;
            this.txtIdMatkul.BorderColor = System.Drawing.Color.Black;
            this.txtIdMatkul.BorderRadius = 10;
            this.txtIdMatkul.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdMatkul.DefaultText = "";
            this.txtIdMatkul.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdMatkul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdMatkul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdMatkul.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdMatkul.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMatkul.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtIdMatkul.ForeColor = System.Drawing.Color.Black;
            this.txtIdMatkul.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdMatkul.Location = new System.Drawing.Point(881, 227);
            this.txtIdMatkul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdMatkul.Name = "txtIdMatkul";
            this.txtIdMatkul.PasswordChar = '\0';
            this.txtIdMatkul.PlaceholderText = "";
            this.txtIdMatkul.SelectedText = "";
            this.txtIdMatkul.Size = new System.Drawing.Size(286, 48);
            this.txtIdMatkul.TabIndex = 68;
            // 
            // btnCari
            // 
            this.btnCari.AutoRoundedCorners = true;
            this.btnCari.BorderRadius = 26;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.Blue;
            this.btnCari.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(1189, 223);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(168, 55);
            this.btnCari.TabIndex = 86;
            this.btnCari.Text = "Cari";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // UpdateDeleteMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cbProdi);
            this.Controls.Add(this.cbPegawai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtJenis);
            this.Controls.Add(this.txtSKS);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtIdMatkul);
            this.Name = "UpdateDeleteMatkul";
            this.Text = "Update Delete Mata Kuliah";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programStudiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fINDSMARTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FINDSMARTDataSet2TableAdapters.ProgramStudiTableAdapter programStudiTableAdapter;
        private FINDSMARTDataSet2 fINDSMARTDataSet2;
        private System.Windows.Forms.BindingSource programStudiBindingSource;
        private System.Windows.Forms.ComboBox cbProdi;
        private FINDSMARTDataSet1 fINDSMARTDataSet1;
        private System.Windows.Forms.BindingSource dosenBindingSource;
        private System.Windows.Forms.ComboBox cbPegawai;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private FINDSMARTDataSet1TableAdapters.DosenTableAdapter dosenTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2TextBox txtSemester;
        private Guna.UI2.WinForms.Guna2TextBox txtJenis;
        private Guna.UI2.WinForms.Guna2TextBox txtSKS;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtIdMatkul;
        private Guna.UI2.WinForms.Guna2Button btnCari;
    }
}