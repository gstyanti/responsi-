using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            //objek karyawan 1
            karyawan karyawan1 = new karyawan;
            
            //peresetan properties
            karyawan1.NIK = "246810";
            karyawan1.NAMA= "gusti";
            karyawan1.GajiBulanan= 3000000;

            //objek karyawan 2
            karyawan karyawan2 = new karyawan;

            //peresetan properties
            karyawan2.NIK = "1357911";
            karyawan2.NAMA = "febri";
            karyawan2.GajiBulanan = 2000000;

            //pemanggilan method
            Console.WriteLine("No. \tNIK\Nama\t\tGaji bulanan");
            Console.WriteLine("\n");
            Console.WriteLine("========PEMBAYARAN GAJI KARYAWAN========");
            Console.WriteLine("\n");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("ASYIIK NAIK GAJI 10%!! ");
            Console.WriteLine("\n");
            Console.WriteLine("========KENAIKAN GAJI 10%========");
            Console.WriteLine("1. \t{0} {1}\t\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. \t{0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();


        }
    }
}
