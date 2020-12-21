using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, i, n;
            Console.Write("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                suma += i;
            }
            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj6\Sbox\wynik1.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Create, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);
            zapis.WriteLine(suma);
            zapis.Close();
            plik.Close();
            Console.ReadKey();
        }
    }
}
