﻿using PROJECT_PRG2.CRUD_Dosen;
using PROJECT_PRG2.CRUD_JenisPrestasi;
using PROJECT_PRG2.CRUD_Mahasiswa;
using PROJECT_PRG2.CRUD_MataKuliah;
using PROJECT_PRG2.CRUD_Pengumuman;
using PROJECT_PRG2.CRUD_PosisiPrestasi;
using PROJECT_PRG2.CRUD_Prodi;
using PROJECT_PRG2.CRUD_Tendik;
using PROJECT_PRG2.Dashboard;
using PROJECT_PRG2.LoginMenu;
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
            //Application.Run(new TampilanAwal());
            //Application.Run(new InputMatkul());
            //Application.Run(new UpTendik());
            Application.Run(new DashboardUtama());
            //Application.Run(new DasboardTendik());
            //Application.Run(new UpdateDelete_JenisPrestasi());
            //Application.Run(new View_JenisPrestasi());
            //Application.Run(new UpdateDelete_JenisPrestasi());
            //Application.Run(new Input_JenisPrestasi());
            //Application.Run(new UpdateDelete_PosisiPrestasi());
            //Application.Run(new Input_PosisiPrestasi());
            //Application.Run(new View_PosisiPrestasi());
            //Application.Run(new View_Prodi());
            //Application.Run(new UpdateDeleteMatkul());
            //Application.Run(new InputJepres());
            //Application.Run(new UDJepres());
            //Application.Run(new LoginKepalaTendik());
            //Application.Run(new DasboardTendik());
        }
    }
}
