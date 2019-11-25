using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelevCal
{
    public class Operasi
    {
        public int a { get; set; }
        public int b { get; set; }
        public string pilih { get; set; }
        public static int Penjumlahan(int a,int b)
        {
            return a + b;
        }
        public static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        public static int Perkalian(int a, int b)
        {
            return a * b;
        }
        public static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
