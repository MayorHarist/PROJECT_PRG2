﻿namespace PROJECT_PRG2.Laporan
{
    partial class LaporanKRPP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.laporanMahasiswaKRPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repKRPP = new PROJECT_PRG2.RepKRPP();
            this.btnCari = new Guna.UI2.WinForms.Guna2Button();
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repKRS = new PROJECT_PRG2.RepKRS();
            this.repKRSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repKRPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporanMahasiswaKRPPTableAdapter = new PROJECT_PRG2.RepKRPPTableAdapters.LaporanMahasiswaKRPPTableAdapter();
            this.laporanMahasiswaBerprestasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporanMahasiswaBerprestasiTableAdapter = new PROJECT_PRG2.RepKRSTableAdapters.LaporanMahasiswaBerprestasiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaKRPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaBerprestasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // laporanMahasiswaKRPPBindingSource
            // 
            this.laporanMahasiswaKRPPBindingSource.DataMember = "LaporanMahasiswaKRPP";
            this.laporanMahasiswaKRPPBindingSource.DataSource = this.repKRPP;
            // 
            // repKRPP
            // 
            this.repKRPP.DataSetName = "RepKRPP";
            this.repKRPP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCari
            // 
            this.btnCari.AutoRoundedCorners = true;
            this.btnCari.BorderRadius = 13;
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(46, 76);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(64, 28);
            this.btnCari.TabIndex = 11;
            this.btnCari.Text = "Cari";
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
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
            this.txtCari.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(126, 76);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderText = "";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(200, 28);
            this.txtCari.TabIndex = 10;
            // 
            // cbFilter
            // 
            this.cbFilter.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(1022, 80);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(193, 31);
            this.cbFilter.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(981, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Realisasi Pencapaian Prestasi Mahasiswa";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.laporanMahasiswaKRPPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROJECT_PRG2.ReportKRPP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(46, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1171, 432);
            this.reportViewer1.TabIndex = 6;
            // 
            // repKRS
            // 
            this.repKRS.DataSetName = "RepKRS";
            this.repKRS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repKRSBindingSource
            // 
            this.repKRSBindingSource.DataSource = this.repKRS;
            this.repKRSBindingSource.Position = 0;
            // 
            // repKRPPBindingSource
            // 
            this.repKRPPBindingSource.DataSource = this.repKRPP;
            this.repKRPPBindingSource.Position = 0;
            // 
            // laporanMahasiswaKRPPTableAdapter
            // 
            this.laporanMahasiswaKRPPTableAdapter.ClearBeforeFill = true;
            // 
            // laporanMahasiswaBerprestasiBindingSource
            // 
            this.laporanMahasiswaBerprestasiBindingSource.DataMember = "LaporanMahasiswaBerprestasi";
            this.laporanMahasiswaBerprestasiBindingSource.DataSource = this.repKRSBindingSource;
            // 
            // laporanMahasiswaBerprestasiTableAdapter
            // 
            this.laporanMahasiswaBerprestasiTableAdapter.ClearBeforeFill = true;
            // 
            // LaporanKRPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 606);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LaporanKRPP";
            this.Text = "KRPP";
            this.Load += new System.EventHandler(this.KRPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaKRPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKRPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanMahasiswaBerprestasiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCari;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource repKRPPBindingSource;
        private RepKRPP repKRPP;
        private RepKRS repKRS;
        private System.Windows.Forms.BindingSource repKRSBindingSource;
        private System.Windows.Forms.BindingSource laporanMahasiswaKRPPBindingSource;
        private RepKRPPTableAdapters.LaporanMahasiswaKRPPTableAdapter laporanMahasiswaKRPPTableAdapter;
        private System.Windows.Forms.BindingSource laporanMahasiswaBerprestasiBindingSource;
        private RepKRSTableAdapters.LaporanMahasiswaBerprestasiTableAdapter laporanMahasiswaBerprestasiTableAdapter;
    }
}