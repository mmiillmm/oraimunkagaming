using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oraimunkagaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            List<string> listafilm = new List<string>();

            List<string> listakonyv = new List<string>();

            StreamReader beolvfilm = new StreamReader("szoveg.txt");

            StreamReader beolvkonyv = new StreamReader("szoveg2.txt");

            while (!beolvfilm.EndOfStream)
            {
                listafilm.Add(beolvfilm.ReadLine());
            }

            while (!beolvkonyv.EndOfStream)
            {
                listakonyv.Add(beolvkonyv.ReadLine());
            }

            Console.WriteLine("Mit szeretne látni: ");

            Console.WriteLine("1 - Top 10 legjobb film");

            Console.WriteLine("2 - Top 10 legjobb H.P. Lovecraft könyv");

            Console.WriteLine("3 - Kilépés");

            int val = Convert.ToInt32(Console.ReadLine());

            if (val == 1)
            {
                Console.WriteLine("Top 10 film: ");

                Console.WriteLine();

                for (int i = 0; i < listafilm.Count; i++)
                {
                    Console.WriteLine($"{num++}. {listafilm[i]}");

                    Console.WriteLine("-------------------");
                }
            }

            else if (val == 2)
            {
                Console.WriteLine("Top 10 H.P. Lovecraft könyv: ");

                Console.WriteLine();

                for (int i = 0; i < listakonyv.Count; i++)
                {
                    Console.WriteLine($"{num++}. {listakonyv[i]}");

                    Console.WriteLine("-------------------");
                }
            }

            else
            {
                Console.WriteLine("Viszlát!");
            }

            beolvfilm.Close();

            beolvkonyv.Close();


            Console.ReadKey();

        }
    }
}
