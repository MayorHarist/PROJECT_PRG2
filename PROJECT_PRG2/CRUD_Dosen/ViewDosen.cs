using PROJECT_PRG2.CRUD_Prodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'fINDSMART.Dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter.Fill(this.fINDSMART.Dosen);

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollableControl scrollableControl = (ScrollableControl)sender;        
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollableControl scrollableControl = (ScrollableControl)(sender);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            DasboardTendik dasboardTendik = new DasboardTendik();
            dasboardTendik.Show();
            this.Hide();
        }
    }
}
