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
            //P5();
            //P6();
            //P7();
            //P8();
        }

        private static void P8()
        {
            //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
            //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];
            int PrimulElement;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            PrimulElement = v[0];

            for (int i = 0; i < n; i++)
            {
                v[i] = v[i + 1];
            }
            v[n - 1] = PrimulElement;

            Console.Write("Dupa rotire: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void P7()
        {
            //Reverse. Se da un vector cu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
            //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int i = 0; i < n; i++)
            {
                v[n - i - 1] = int.Parse(t[i]);
            }

            Console.Write("Dupa inversare: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void P6()
        {
            //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
            //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.
            int n, k;
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
            }

            for (int i = k; i < n; i++)
            {
                v[i] = v[i + 1];
            }
            n--;
            Console.Write("Dupa eliminare: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }

        private static void P5()
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k.
            //Primul element al vectorului se considera pe pozitia zero.
            int n, e, k;
            Console.Write("e=");
            e = int.Parse(Console.ReadLine());
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
            }
            n++;
            for (int i = n - 1; i >= k; i--)
            {
                v[i + 1] = v[i];
            }
            v[k] = e;
            Console.Write("Dupa inserare: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
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
                else if (v[i] == minv)
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
                if (v[i] < minv)
                {
                    minv = v[i];
                    pozmin = i;
                }
                if (v[i] > maxv)
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
                if (v[i] == k)
                {
                    poz = i;
                    break;
                }
            }
            Console.WriteLine(poz + 1);
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
