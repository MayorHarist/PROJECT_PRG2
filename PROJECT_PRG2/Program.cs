using PROJECT_PRG2.CRUD_Dosen;
using PROJECT_PRG2.CRUD_JenisPrestasi;
using PROJECT_PRG2.CRUD_Mahasiswa;
using PROJECT_PRG2.CRUD_MataKuliah;
using PROJECT_PRG2.CRUD_Pengumuman;
using PROJECT_PRG2.CRUD_PosisiPrestasi;
using PROJECT_PRG2.CRUD_Prodi;
using PROJECT_PRG2.CRUD_Tendik;
using PROJECT_PRG2.Dashboard;
using PROJECT_PRG2.Laporan;
using PROJECT_PRG2.LoginMenu;
using PROJECT_PRG2.Transaksi;
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
            Application.Run(new DashboardUtama());
        }
    }
}
