using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROJECT_PRG2
{
    public partial class TampilanAwal : Form
    {
        public TampilanAwal()
        {
            InitializeComponent();
            
        }
        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();


            formLogin.Show();


            this.Hide();
        }
    }
}
