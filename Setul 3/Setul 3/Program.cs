﻿using System;
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
            //P9();?
            //P10();?
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();?
        }

        private static void P17()
        {
            //Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.
            int n, b;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            int p = 1, cifra, cn = n;
            long result = 0;
            while (n != 0)
            {
                cifra = n % b;
                n = n / b;
                result = result + cifra * p;
                p = p * 10;
            }
            //-merge doar daca b<=10;
            Console.WriteLine($"Numarul {cn} convertit in baza {b} este: {result}.");
        }

        private static void P16()
        {
            //Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];
            int maxv = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                if (v[i] > maxv)
                    maxv = v[i];
            }

            int divmax = -1;

            for (int i = maxv; i > 0; i--)
            {
                bool ok = true;
                for (int j = 0; j < n; j++)
                {
                    if (v[j] % i != 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    divmax = i;
                    break;
                }
            }

            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este {divmax}.");
        }

        private static void P15()
        {
            //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int l = 0; l < n; l++)
            {
                v[l] = int.Parse(t[l]);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] == v[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            v[k] = v[k + 1];
                        }
                        n--;
                    }
                }
            }

            for (int l = 0; l < n; l++)
            {
                Console.Write($"{v[l]} ");
            }

            Console.WriteLine();
        }

        private static void P14()
        {
            //Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
            //(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului)
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int l = 0; l < n; l++)
            {
                v[l] = int.Parse(t[l]);
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (v[i] == 0)
                {
                    for (int j = n - 1; j > i; j--)
                        if (v[j] != 0)
                        {
                            v[i] = v[j];
                            v[j] = 0;
                            break;
                        }
                }
            }

            for (int l = 0; l < n; l++)
            {
                Console.Write($"{v[l]} ");
            }

            Console.WriteLine();
        }

        private static void P13()
        {
            //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int l = 0; l < n; l++)
            {
                v[l] = int.Parse(t[l]);
            }

            int i, k;

            for (i = 1; i < n; i++)
            {
                for (k = i; k > 0 && v[k] < v[k - 1]; k--)
                {
                    Swap(v, k, k - 1);
                }
            }

            for (int l = 0; l < n; l++)
            {
                Console.Write($"{v[l]} ");
            }

            Console.WriteLine();
        }

        private static void P12()
        {
            //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            Console.Write($"Cele {n} numre sunt: ");

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int[] v = new int[1000];

            for (int l = 0; l < n; l++)
            {
                v[l] = int.Parse(t[l]);
            }

            int i, j, k;

            for (i = 0; i < n; i++)
            {
                k = i;
                for (j = i + 1; j < n; j++)
                {
                    if (v[j] < v[k])
                        k = j;
                }
                Swap(v, i, k);
            }

            for (int l = 0; l < n; l++)
            {
                Console.Write($"{v[l]} ");
            }

            Console.WriteLine();
        }

        private static void Swap(int[] v, int i, int j)
        {
            int aux;
            aux = v[i];
            v[i] = v[j];
            v[j] = aux;
        }

        private static void P11()
        {
            //Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).
            int n, i = 2;
            bool ok;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write($"Numerele prime mai mici sau egale cu {n} sunt: ");
            while (i <= n)
            {
                ok = true;
                if (i % 2 == 0 && i != 2)
                    ok = false;
                for (int d = 3; d * d <= i; d = d + 2)
                    if (i % d == 0)
                        ok = false;
                if (ok)
                {
                    Console.Write($"{i} ");
                }
                i++;
            }
            Console.WriteLine();
        }

        private static void P10()
        {
            //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k.
            //Daca elementul nu se gaseste in vector rezultatul va fi -1.
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

            int st = 0, dr = n - 1, poz = -1, mij;

            while (st < dr && poz == -1)
            {
                mij = (st + dr) / 2;
                if (v[mij] == k)
                    poz = mij;
                else
                {
                    if (v[mij] < k)
                        st = mij + 1;
                    else
                        dr = mij - 1;
                }
            }

            Console.WriteLine(poz);
        }

        private static void P9()
        {
            //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
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
            int n, k, poz = -2;
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
