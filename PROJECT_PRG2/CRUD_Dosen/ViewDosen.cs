﻿using System;
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
            // TODO: This line of code loads data into the 'fINDSMARTDataSet.Dosen' table. You can move, or remove it, as needed.
           

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            this.dosenTableAdapter.Fill(this.fINDSMARTDataSet.Dosen);
        }
    }
}