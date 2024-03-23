using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5 {
class Penjumlahan<T>
{
    public dynamic JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic A = angka1;
        dynamic B = angka2;
        dynamic C = angka3;

        return A + B + C;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan<int> JumlahTigaAngka = new Penjumlahan<int>();
        Console.WriteLine(JumlahTigaAngka.JumlahTigaAngka(13, 02, 22));
    }
}
}
