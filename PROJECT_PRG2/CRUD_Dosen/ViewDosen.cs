using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PROJECT_PRG2.CRUD_Dosen
{
    public partial class ViewDosen : Form
    {
        public ViewDosen()
        {
            InitializeComponent();
        }

        private void ViewDosen_Load(object sender, EventArgs e)
        {
            // Load data into the 'fINDSMART.Dosen' table.
            this.dosenTableAdapter.Fill(this.fINDSMART.Dosen);

            // Ensure the Guna2DataGridView scrollbars are set correctly
            this.dgvDosen.ScrollBars = ScrollBars.Both;

            // Ensure AutoSizeColumnsMode is set
            this.dgvDosen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ensure some columns exceed the width of the DataGridView
            foreach (DataGridViewColumn column in dgvDosen.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                column.Width = 200; // Adjust this width as necessary
            }

            // Refresh the DataGridView to ensure scrollbars appear
            this.dgvDosen.Refresh();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            // Your code to display data in DataGridView
        }

        private void VScroll_Scroll(object sender, ScrollEventArgs e)
        {
            // Link the Guna2ScrollBar to the DataGridView
            this.dgvDosen.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void HScroll_Scroll(object sender, ScrollEventArgs e)
        {
            // Link the Guna2ScrollBar to the DataGridView
            this.dgvDosen.HorizontalScrollingOffset = e.NewValue;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DasboardTendik dasboardTendik = new DasboardTendik();
            dasboardTendik.Show();
            this.Hide();
        }
    }
}
