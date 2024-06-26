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
    public partial class DasboardTendik : Form
    {
        private bool panelMuncul = false;
        private int tinggiPanel = 355;
        private int step = 10;
        public DasboardTendik()
        {
            InitializeComponent();
            panelData.Height = 0;
            dataTimer.Interval = 10;
            dataTimer.Tick += dataTimer_Tick;   
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            if (panelMuncul)
            {

            }
        }
    }
}
