using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
        }

        private static void P4()
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];
            int minv = int.MaxValue, maxv = int.MinValue;
            int kmin = 0, kmax = 0;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] < minv)
                {
                    minv = v[i];
                    kmin = 1;
                }
                else if(v[i]==minv)
                {
                    kmin++;
                }
                if (v[i] > maxv)
                {
                    maxv = v[i];
                    kmax = 1;
                }
                else if (v[i] == maxv)
                {
                    kmax++;
                }
            }
            Console.WriteLine($"Valoarea minima este {minv} si apare de {kmin} ori, iar valoarea maxima este {maxv} si apare de {kmax} ori.");
        }

        private static void P3()
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            //Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];
            int minv = int.MaxValue, maxv = int.MinValue;
            int pozmin = -1, pozmax = -1;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if(v[i]<minv)
                {
                    minv = v[i];
                    pozmin = i;
                }
                if(v[i]>maxv)
                {
                    maxv = v[i];
                    pozmax = i;
                }
            }
            Console.WriteLine($"Cel mai mic element se afla pe pozitia {pozmin + 1}, iar cel mai mare element pe pozitia {pozmax + 1}.");
        }

        private static void P2()
        {
            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.
            //Daca k nu apare in vector rezultatul va fi -1.
            int n, k, poz = -1;
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if(v[i]==k)
                {
                    poz = i;
                    break;
                }
            }
            Console.WriteLine(poz+1);
        }

        private static void P1()
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
            int n, suma = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                suma = suma + v[i];
            }
            Console.WriteLine($"Suma elementelor este {suma}.");
        }
    }
}
