using PROJECT_PRG2.CRUD_Dosen;
using PROJECT_PRG2.LoginMenu;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint,
                          true);
            this.UpdateStyles();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            TampilanAwal tampilanAwal = new TampilanAwal();
            tampilanAwal.Show();
            this.Hide();
        }

        private void btnLoginTendik_Click(object sender, EventArgs e)
        {
            LoginSbgTenDik loginTenagaPendidik = new LoginSbgTenDik();
            loginTenagaPendidik.Show(); 
            this.Hide();
        }

        private void btnKepalaTendik_Click(object sender, EventArgs e)
        {
            LoginKepalaTendik loginKepalaTendik = new LoginKepalaTendik();  
            loginKepalaTendik.Show();
            this.Hide();
        }

        private void btnLoginMhs_Click(object sender, EventArgs e)
        {
            LoginMahasiswa loginMahasiwa = new LoginMahasiswa();
            loginMahasiwa.Show();
            this.Hide();
        }
    }
}
