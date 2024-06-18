using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_PosisiPrestasi
{
    public partial class View_PosisiPrestasi : Form
    {
        public View_PosisiPrestasi()
        {
            InitializeComponent();
        }

        private void View_PosisiPrestasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet5.PosisiPrestasi' table. You can move, or remove it, as needed.
            //this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet5.PosisiPrestasi);

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet5.PosisiPrestasi' table. You can move, or remove it, as needed.
            this.posisiPrestasiTableAdapter.Fill(this.fINDSMARTDataSet5.PosisiPrestasi);
        }
    }
}
