using System;

namespace ConsoleApplication1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            for (int l = 1; l <= 5; l++)
            {
                Console.WriteLine("Numero " + l);
            }

            Console.WriteLine("esercizio 1");
            for (int a=10;a>=1;a--)
            {
                Console.WriteLine("Numero " + a);
            }
            Console.WriteLine("esercizio 2");
            for (int q = 1; q <= 20; q++)
            {
                if (q % 2 == 0)
                    Console.WriteLine("Numero " + q);
            }
            Console.WriteLine("esercizio 3");
            for(int ii=0;ii<=50;ii++)
            {
                if (ii % 5== 0)
                    Console.WriteLine("Numero " + ii);
            }
            Console.WriteLine("esercizio 4, inserisci numero");
            //esercizio 4
            string numo=Console.ReadLine();
            int numero=Convert.ToInt32(numo);
            int j = 0;
            for (int v = 1; v <= numero; v++)
            {
                j += v;
                //Console.WriteLine(j); 
            }
            Console.WriteLine(j);
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //esercizi while
            Console.WriteLine("Esercizio while 1");
            int m = 1;
            while (m <= 20)
            {
                if (m % 3 == 0)
                    Console.WriteLine(m);
                m++;
            }
            Console.WriteLine("Esercizio while 2: inserisci numero");
            string numero2 = Console.ReadLine();
            int p=Convert.ToInt32(numero2);
            while (p != 0)
            {
                Console.WriteLine("inserisci numero intero");
                numero2 = Console.ReadLine();
                p = Convert.ToInt32(numero2);
            }

            //esercizio 3
            Console.WriteLine("Esercizio while 3: inserisci numero intero");
            string numero3 = Console.ReadLine();
            int numero4 = Convert.ToInt32(numero3);
            while (numero4 >= 0)
            {
                Console.WriteLine("Esercizio while 3: inserisci altro intero");
                numero3=Console.ReadLine();
                numero4 = Convert.ToInt32(numero3);
            }

            int somma = 0;
            int w = 1;
            while (w <= 5)
            {
                Console.WriteLine("Esercizio while 4: inserisci l'intero "+w);
                numero3=Console.ReadLine();
                numero4 = Convert.ToInt32(numero3); 
                somma += numero4;
                w += 1;
            }
            Console.WriteLine(somma);
        }
    }
}