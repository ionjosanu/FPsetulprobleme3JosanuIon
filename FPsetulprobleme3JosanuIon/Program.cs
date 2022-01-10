using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FPsetulprobleme3JosanuIon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buna ziua si va multumesc pentru atentie!\n\n" +
              "Ma numesc Josanu Ion, student anul I la Facutlatea de Informatica si Stiinte a Univsersitatii din Oradea, specializarea Informatica.\n\n" +
              "Acesta este al treilea set de probleme rezolvate la disciplina Fundamentele Programarii.\n\n" +
              "Va rog sa introduceti numarul problemei(1-31) pentru verificare :");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Conditia : Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran."); P1(); break;
                case 2: Console.WriteLine("Conditia : Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. "); P2(); break;
                case 3: Console.WriteLine("Conditia : Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). "); P3(); break;
                case 4: Console.WriteLine("Conditia : Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea."); P4(); break;
                case 5: Console.WriteLine("Conditia : Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. "); P5(); break;
                case 6: Console.WriteLine("Conditia : Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. "); P6(); break;
                case 7: Console.WriteLine("Conditia : Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc."); P7(); break;
                case 8: Console.WriteLine("Conditia : Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. "); P8(); break;
                case 9: Console.WriteLine("Conditia : Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. "); P9(); break;
                case 10: Console.WriteLine("Conditia : Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1."); P10(); break;
                case 11: Console.WriteLine("Conditia : Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).  "); P11(); break;
                case 12: Console.WriteLine("Conditia : Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. "); P12(); break;
                case 13: Console.WriteLine("Conditia : Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>"); P13(); break;
               //14 nu e facuta
                case 14: Console.WriteLine("Conditia : Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). "); P14(); break;
                case 15: Console.WriteLine("Conditia : Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector."); P15(); break;
                case 16: Console.WriteLine("Conditia : Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului."); P16(); break;
            }
        }

        private static void P16()
        {
            
        }

        private static void P15()
        {
            Console.Write("Introduceti n, care va reprezenta nr de elemente ale vectorului : "); int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(20);
            }

            Console.Write("Vectorul initial : ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i!=j && vector[i]==vector[j])
                    {
                        for (int k = j; k < n-1; k++)
                        {
                            vector[k] = vector[k + 1];
                            
                        }
                        n--;
                    }
                   
                }
            }
            Console.WriteLine();
            Console.Write("Vectorul final : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }


            Console.ReadKey();
        }

        private static void P14()
        {
            int[] vector = new int[10] {1,0, 0, 2, 3, 0, 4, 0, 5 , 0};
            for (int i = 0; i < vector.Length; i++)
            {

            }
        }

        private static void P13()
        {
            Console.Write("Introduceti n, care va reprezenta nr de elemente ale vectorului : "); int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(100);
            }

            Console.Write("Vectorul ianinte de sortare : ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            int k, aux;
            for (int i = 1; i < vector.Length; i++)
            {
                for (k = i; k > 0 && vector[k] < vector[k - 1]; k--)
                {
                    aux = vector[k];
                    vector[k] = vector[k-1];
                    vector[k-1] = aux;
                }
            }

            Console.WriteLine();
            Console.Write("Vectorul dupa sortarea prin insertie : ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.ReadKey();
        }

        private static void P12()
        {
            Console.Write("Introduceti n, care va reprezenta nr de elemente ale vectorului : "); int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(100);
            }
            Console.Write("Vectorul ianinte de sortare : ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]+" ");
            }
            int min, aux;
            Console.WriteLine();
            for (int i = 0; i < vector.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[j] < vector[min])
                    {
                        min = j;
                    }
                }
                aux = vector[min];
                vector[min] = vector[i];
                vector[i] = aux;
            }

            Console.Write("Vectorul dupa sortarea prin selectie : ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.ReadKey();
        }

        private static void P11()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            int[] NumerePrime=new int[100];
            int pozitie = -1;
            for (int i = 1; i <=n ; i++)
            {
                int prim = 0;
                int m = i / 2;
                for (int j = 2; j <=m; j++)
                {
                    if (i
                        %j==0)
                    {
                        prim = 1;
                    }
                }
                if (prim == 0)
                {
                 NumerePrime[pozitie + 1] = i; pozitie++;
                }

            }
            Console.Write("Numerele prime pana la {0} sunt : ",n);
            for (int i = 0; i <= pozitie; i++)
            {
                Console.Write(NumerePrime[i] + " ");
            }
            Console.ReadKey();
          
        }

        private static void P10()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            string[] vector = elemente.Split(' ');
            Console.Write("Introduceti elementul k : "); int k = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i <n; i++)
            {
                if (int.Parse(vector[i])==k)
                {
                    poz = i;
                    break;
                }
            }
            Console.WriteLine("pozitia este: {0}", poz);
            Console.ReadKey();
        }

        private static void P9()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            string[] vector = elemente.Split(' ');
            Console.Write("Introduceti k : "); int k = int.Parse(Console.ReadLine());
            int x = 0;
            while (x!=k)
            {
                string y = vector[0];
                for (int i = 0; i < n - 1; i++)
                {
                    
                    vector[i] = vector[i + 1];
                }
                vector[n - 1] = y;
                x++;
            }
            Console.Write("Vectorul nou este : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.ReadKey();
        }

        private static void P8()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            string[] vector = elemente.Split(' ');
            string x = vector[0];
            for (int i = 0; i < n-1; i++)
            {
                vector[i] = vector[i + 1];
            }
            vector[n - 1] = x;
            Console.Write("Vectorul nou este : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.ReadKey();
        }

        private static void P7()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            string[] vector = elemente.Split(' ');
            Array.Reverse(vector);
            Console.Write("Vectorul nou este : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.ReadKey();
        }

        private static void P6()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            Console.Write("Introduceti pozitia k : "); int k = int.Parse(Console.ReadLine());
            string[] vector = elemente.Split(' ');
            for (int i = k; i < n-1; i++)
            {
                vector[i] = vector[i + 1];
            }
            vector[n - 1] = null;
            n--;
            Console.Write("Vectorul nou este : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.ReadKey();
        }

        private static void P5()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            Console.Write("Introduceti valoarea e : "); string e = Console.ReadLine();
            Console.Write("Introduceti pozitia k : "); int k = int.Parse(Console.ReadLine());
            string[] vector = elemente.Split(' ') ;
            Array.Resize(ref vector, n+1);
           
            for (int i = n-1; i >= k; i--)
            {
                vector[i+1] = vector[i];

                if (i==k)
                {
                    vector[k] = e;
                }
            }
            vector[n - 1] = null;
            Console.Write("Vectorul nou este : ");
            for (int i = 0; i < n ; i++)
            {
                Console.Write(vector[i]+" ");
            }
            Console.ReadKey();
        }

        private static void P4()
        {
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            string[] vector = elemente.Split(' ');
           
            double nrmax = double.Parse(vector[0]);
            int repnrmax = 0;
            double nrmin = double.Parse(vector[0]);
            int repnrmin = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                double local = double.Parse(vector[i]);
                if (local >= nrmax)
                {
                    nrmax = local;
                    repnrmax = 0;
                    for (int j = 0; j < vector.Length; j++)
                    {
                        if (nrmax==double.Parse(vector[j]))
                        {
                            repnrmax++;
                        }
                    }
                }
                if (local <= nrmin)
                {
                    nrmin = local;
                    repnrmin = 0;
                    for (int j = 0; j < vector.Length; j++)
                    {
                        if (nrmin == double.Parse(vector[j]))
                        {
                            repnrmin++;
                        }
                    }
                }
            }
            Console.WriteLine("Cea mai mare valoare a vectorului est {0} si se repeta de {1} ori",nrmax, repnrmax);
            Console.WriteLine("Cea mai mica valoare a vectorului est {0} si se repeta de {1} ori", nrmin, repnrmin);
            Console.ReadKey();
        }

        private static void P3()
        {
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            string[] vector = elemente.Split(' ');
            int posnrmax=0;
            int posnrmin=0;
            double nrmax = double.Parse(vector[0]);
            double nrmin=double.Parse(vector[0]);
            for (int i = 0; i < vector.Length; i++)
            {
                double local = double.Parse(vector[i]);
                if (local>nrmax)
                {
                    nrmax = local;
                    posnrmax = i;
                }
                if (local<nrmin)
                {
                    nrmin = local;
                    posnrmin=i;
                }
            }
            Console.WriteLine("Pozitia celui mai mic element este : {0}",posnrmin);
            Console.WriteLine("Pozitia celui mai mare element este : {0}",posnrmax);
            Console.ReadKey();
        }

        private static void P2()
        {
            Console.Write("Introduceti n : "); int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            Console.Write("Introduceti k : "); int k = int.Parse(Console.ReadLine());
            string[] vector = elemente.Split(' ');
            int pozitia = -1;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(vector[i])==k)
                {
                    pozitia = i;
                    break;
                }
            }
            Console.WriteLine("Rezultatul este : {0}",pozitia);
            Console.ReadKey();

        }

        private static void P1()
        {
            Console.Write("Introduceti n : "); int n=int.Parse(Console.ReadLine());
            Console.Write("Introduceti elementele vectorului separate prin spatiu : "); string elemente = Console.ReadLine();
            string[] vector = elemente.Split(' ');
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma = suma + int.Parse(vector[i]);
            }
            Console.WriteLine("Suma elementelor vectorului de {0} elemente este : {1}",n,suma);
            Console.ReadKey();
        }
    }
}
