using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan1 = new Karyawan();
            karyawan1.No = 1;
            karyawan1.NIM = 19112806;
            karyawan1.Nama = "Henita";
            karyawan1.GajiBulanan = 3000000;

            Karyawan karyawan2 = new Karyawan();
            karyawan2.No = 2;
            karyawan2.NIM = 19112847;
            karyawan2.Nama = "Lanang";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("No /   NIM/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.karyawan();
            karyawan2.karyawan();
            Console.WriteLine("");
            Console.WriteLine("Anda dapat tambahan gaji 10%");
            Console.WriteLine("");
            Console.WriteLine("No /   NIM/Nama/Gaji     ");
            Console.WriteLine("----------------------------------------");
            karyawan1.GajiTambahan();
            karyawan2.GajiTambahan();

            Console.ReadKey();
        }
    }
}
