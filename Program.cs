using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nome = "Daniele";
            string cognome;
            cognome = "S";

            nome = "Mario";
            cognome = "Rosso";

            string testo = "prova";
            char carattere = 'c';
            int intero = 2;
            long lungo = 1;
            float numero1 = 6.2F;
            double x = 4.5;
            decimal decimale = 4.5M;
            bool sino = true;

            Console.WriteLine("ciao " + nome + carattere);

            int bas = 5;
            int altezza = 7;
            int area = bas * altezza;
            Console.WriteLine("ciao, l'area del rettangolo è: " + area);

            int uno = 4;
            int due = 6;

            int somma = uno + due;
            int differenza = uno - due;
            int prodotto = uno * due;
            int divisione = uno / due;

            Console.WriteLine("somma " + somma + " differenza " + differenza + " prodotto " + prodotto + " divisione " + divisione);

            int perimetro = uno * 2 + due * 2;
            int areaUno = uno * due;

            Console.WriteLine("perimetro " + perimetro + " area " + areaUno);

            int b1 = 8;
            int b2 = 6;
            int areUn = (b1 * b2) / 2;

            Console.WriteLine("area triangolo " + areUn);

            int raggio = 8;
            float pi = 3.14F;

            float circonf = raggio * 2 * pi;
            float areaCerchio = raggio * raggio * pi;

            Console.WriteLine("circonf: " + circonf + " area: " + areaCerchio);

            int prova = 4;
            long qwerty = prova;

            double prova1 = 3.4;
            int numero2 = (int)prova1;

            int numero3 = 23;
            string stringa = Convert.ToString(numero3);

            Console.WriteLine("Inserisci il primo numero");
            string inputUtente = Console.ReadLine();

            Console.WriteLine("Inserisci il secondo numero");
            string inputUtente2 = Console.ReadLine();
            
            Console.WriteLine("Inserisci il terzo numero");
            string inputUtente3 = Console.ReadLine();

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            try
            {
                num1 = int.Parse(inputUtente);
                num2 = int.Parse(inputUtente2);
                num3=  int.Parse(inputUtente3);
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Numero invalido");
            }

            if (num1 > num2 && num1>num3)
                Console.WriteLine("Numero " + num1 + " maggiore");
            else if (num1 < num2 && num2>num3)
                Console.WriteLine("Numero " + num2 + " maggiore");
            else if (num3>num1 && num3>num2)
                Console.WriteLine("Numero " + num3 + " maggiore");
            else
                Console.WriteLine("I numeri sono uguali");

            // età
            Console.WriteLine("Inserisci la tua età");
            string nombre = Console.ReadLine();

            int age = int.Parse(nombre);

            if (age > 17)
                Console.WriteLine("Sei maggiorenne");
            else
                Console.WriteLine("Sei minorenne");

            // triangolo
            Console.WriteLine("Inserisci lunghezza lato1");
            int lato1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci lunghezza lato2");
            int lato2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci lunghezza lato3");
            int lato3 = int.Parse(Console.ReadLine());

            if (lato1 == lato2 && lato2 == lato3)
                Console.WriteLine("Triangolo equilatero");
            else if (lato1 == lato2 || lato1 == lato3 || lato2 == lato3)
                Console.WriteLine("Triangolo isoscele");
            else
                Console.WriteLine("Triangolo scaleno");

            // anno 1969
            Console.WriteLine("Inserisci la tua età");
            int agen = int.Parse(Console.ReadLine());

            int annoNascita = 2026 - agen;

            if (annoNascita == 1969)
                Console.WriteLine("Sei nato l'anno dello sbarco sulla luna!");
            else if (annoNascita > 1969)
                Console.WriteLine("Sei nato " + (annoNascita - 1969) + " anni dopo il 1969");
            else
                Console.WriteLine("Sei nato " + (1969 - annoNascita) + " anni prima del 1969");
            //switch case
            int numero;
            Console.WriteLine("Inserisci un numero da 1 a 3");
            numero=Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Hai scelto il numero 1");
                    break;
                case 2:
                    Console.WriteLine("Hai scelto il numero 2");
                    break;
                case 3:
                    Console.WriteLine("Hai scelto il numero 3");
                    break;
            }

            int giorno;
            Console.WriteLine("Inserisci un giorno da 1 a 7");
            giorno=Convert.ToInt32(Console.ReadLine());
            switch (giorno)
            {
                case 1:
                    Console.WriteLine("Hai scelto il lunedì");
                    break;
                case 2:
                    Console.WriteLine("Hai scelto il martedì");
                    break;
                case 3:
                    Console.WriteLine("Hai scelto il mercoledì");
                    break;
                case 4:
                    Console.WriteLine("Hai scelto il giovedì");
                    break;
                case 5:
                    Console.WriteLine("Hai scelto il venerdì");
                    break;
                case 6:
                    Console.WriteLine("Hai scelto il sabato");
                    break;
                case 7:
                    Console.WriteLine("Hai scelto la domenica");
                    break;
            }

            int valore = 0;
            int valoreDue = 0;
            int operazione = 0;
            int risultato;
            risultato = 0;
            Console.WriteLine("Inserisci un valore");
            valore=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un secondo valore");
            valoreDue=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci 1 per sommare,2 per sottrarre,3 per moltiplicare, 4 per dividere");
            operazione=Convert.ToInt32(Console.ReadLine());
            switch (operazione)
            {
                case 1:
                    Console.WriteLine("Hai scelto l'addizione");
                    risultato=valore+valoreDue;
                    Console.WriteLine(risultato);
                    break;
                case 2:
                    Console.WriteLine("Hai scelto la sottrazione");
                    risultato=valore-valoreDue;
                    Console.WriteLine(risultato);
                    break;
                case 3:
                    Console.WriteLine("Hai scelto la moltiplicazione");
                    risultato = valore*valoreDue;
                    Console.WriteLine(risultato);
                    break;
                case 4:
                    Console.WriteLine("Hai scelto la divisione");
                    if (valoreDue != 0)
                    {
                        risultato = valore / valoreDue;

                        Console.WriteLine(risultato);
                        break;
                    }
                    else
                    Console.WriteLine("INDEFINITA");
                    break;
                    
 
            }
        }
        
    }
}