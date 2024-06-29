using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROJECT_PRG2.Dashboard
{
    public partial class DashboardUtama : Form
    {
        public DashboardUtama()
        {
            InitializeComponent();

            // Load the image into the PictureBox
            guna2PictureBox1.Image = Image.FromFile("C:\\Users\\Dean Fiqri\\KULIAH ASTRATECH\\SEMESTER 2\\PROJEK MAHASISWA BERPRESTASI KEL 8\\PROJECT_PRG2\\PROJECT_PRG2\\Resources\\Dashboard Utama Smart.png"); // Ganti dengan path gambar Anda
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            // Set the PictureBox to fit within the Panel
            guna2Panel1.Controls.Add(guna2PictureBox1);

            // Initialize the scrollbar
            guna2VScrollBar1.Maximum = guna2PictureBox1.Height - panel1.ClientSize.Height;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.SmallChange = 1;
            guna2VScrollBar1.LargeChange = 10;
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            guna2Panel1.VerticalScroll.Value = guna2VScrollBar1.Value;
            guna2Panel1.PerformLayout();
        }

        private void DashboardUtama_Load(object sender, EventArgs e)
        {
            // This ensures the panel has scrollbars if needed
            guna2Panel1.AutoScroll = true;
        }
    }
}
