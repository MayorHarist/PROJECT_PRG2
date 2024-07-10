namespace PROJECT_PRG2.Laporan
{
    partial class KRPP
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
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbUrutkan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.AutoRoundedCorners = true;
            this.btnCari.BorderRadius = 13;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(27, 76);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(64, 28);
            this.btnCari.TabIndex = 11;
            this.btnCari.Text = "Cari";
            // 
            // txtCari
            // 
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(107, 76);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(200, 28);
            this.txtCari.TabIndex = 10;
            // 
            // cbUrutkan
            // 
            this.cbUrutkan.FormattingEnabled = true;
            this.cbUrutkan.Location = new System.Drawing.Point(581, 80);
            this.cbUrutkan.Name = "cbUrutkan";
            this.cbUrutkan.Size = new System.Drawing.Size(193, 21);
            this.cbUrutkan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Urutkan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Realisasi Pencapaian Prestasi Mahasiswa";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(27, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(747, 304);
            this.reportViewer1.TabIndex = 6;
            // 
            // KRPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cbUrutkan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "KRPP";
            this.Text = "KRPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private System.Windows.Forms.ComboBox cbUrutkan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}