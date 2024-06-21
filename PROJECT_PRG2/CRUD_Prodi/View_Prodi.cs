using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Prodi
{
    public partial class View_Prodi : Form
    {
        public View_Prodi()
        {
            InitializeComponent();
        }

        private void View_Prodi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.ProgramStudi' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'fINDSMARTDataSet3.ProgramStudi' table. You can move, or remove it, as needed.


        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            this.programStudiTableAdapter.Fill(this.fINDSMARTDataSet6.ProgramStudi);
        }
    }
}
