using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {

            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj6\Sbox\choinka.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Append, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);


            Console.WriteLine("Podaj wysokość choinki: ");
            int n = int.Parse(Console.ReadLine());

            int p = 2 * n - 1; // długość podstawy
            int j;
           

            for (int i = 1; i <= n; i++) // i - numer wiersza
            {
                int x = 2 * i - 1;

                // drukujemy spacje poprzedzające
                for (j = 0; j < (p-x)/2; j++)
                {
                    zapis.Write(" ");
                }

                // drukujemy gwiazdki
                for (j = 0; j < x; j++)
                {
                    zapis.Write("*");
                }

                // drukujemy spacje końcowe 
                for (j = 0; j < (p - x) / 2; j++)
                {
                    zapis.Write(" ");
                }

                // przejście do nowej linii
                zapis.WriteLine();

            }

            zapis.Close();
            plik.Close();
            Console.ReadKey();
        }
    }
}
