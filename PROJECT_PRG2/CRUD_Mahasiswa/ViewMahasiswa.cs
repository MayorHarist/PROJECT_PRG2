using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2.CRUD_Mahasiswa
{
    public partial class ViewMahasiswa : Form
    {
        public ViewMahasiswa()
        {
            InitializeComponent();
        }

        private void ViewMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINDSMARTDataSet6.Mahasiswa' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'fINDSMART.Mahasiswa' table. You can move, or remove it, as needed.


        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            this.mahasiswaTableAdapter.Fill(this.fINDSMARTDataSet6.Mahasiswa);
        }
    }
}
