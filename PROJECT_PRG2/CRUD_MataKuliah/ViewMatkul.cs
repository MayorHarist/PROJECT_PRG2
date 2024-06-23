using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_MataKuliah
{
    public partial class ViewMatkul : Form
    {
        public ViewMatkul()
        {
            InitializeComponent();
        }

        private void ViewMatkul_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.MataKuliah' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'fINDSMART.MataKuliah' table. You can move, or remove it, as needed.


        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            this.mataKuliahTableAdapter.Fill(this.fINDSMARTDataSet6.MataKuliah);
        }
    }
}
