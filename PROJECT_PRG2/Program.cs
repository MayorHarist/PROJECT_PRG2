﻿using PROJECT_PRG2.CRUD_Dosen;
using PROJECT_PRG2.CRUD_JenisPrestasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary><?xml version="1.0" encoding="utf-8"?>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TampilanAwal());
            //Application.Run(new Input_JenisPrestasi());
        }
    }
}
