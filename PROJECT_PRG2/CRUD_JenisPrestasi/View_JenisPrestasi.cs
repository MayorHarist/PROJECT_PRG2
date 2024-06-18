using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_JenisPrestasi
{
    public partial class View_JenisPrestasi : Form
    {
        public View_JenisPrestasi()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet4.JenisPrestasi' table. You can move, or remove it, as needed.
            this.jenisPrestasiTableAdapter.Fill(this.fINDSMARTDataSet4.JenisPrestasi);
        }

        private void View_JenisPrestasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet4.JenisPrestasi' table. You can move, or remove it, as needed.
            //this.jenisPrestasiTableAdapter.Fill(this.fINDSMARTDataSet4.JenisPrestasi);

        }
    }
}
