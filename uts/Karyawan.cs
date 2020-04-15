using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int No { get; set; }
        public int NIM { get; set; }
        public Karyawan(string Nama, int GajiBulanan, int No, int NIK)
        {
            this.Nama = Nama;
            this.No = No;
            this.NIM = NIM;
            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = GajiBulanan;
            }
        }
        public void karyawan()
        {
            Console.WriteLine("{0}  \t {1} \t {2} \t {3} ", No, NIM, Nama, GajiBulanan);
        }
        public void GajiTambahan()
        {
            if (GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
            Console.WriteLine("{0}  \t {1} \t {2} \t {3} ", No, NIM, Nama, GajiBulanan*0.1+GajiBulanan);
        }
    }
}
