using System;//namespace C#

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Tipologia costanti e variabili
            //inizializzazione
            string nome = "Daniele";
            //dichiarazione
            string cognome;
            //assegnazione
            cognome = "S";
            //Riassegnazione
            nome = "Mario";
            cognome = "Rosso";
            //Tipi di dati
            string testo = "prova";
            char carattere = 'c';
            int intero = 2; //2 Miliardi massimo
            long lungo = 1; //oltre 2 miliarsi
            float numero1 = 6.2F; //tra 6 e 9 numeri
            double x = 4.5;
            decimal decimale = 4.5M; //28.29 numeri
            bool sino = true; //vero o falso
            //Casting implicito
            Console.WriteLine("ciao "+nome+carattere);
            int bas = 5;
            int altezza = 7;
            int area = bas * altezza;
            Console.WriteLine("ciao, l'area del rettangolo è: "+area);
            int uno = 4;
            int due = 6;
            int somma = uno + due;
            int differenza = uno - due;
            int prodotto = uno * due;
            int divisione=uno / due;
            Console.WriteLine("somma "+somma+" ,differenza "+differenza+" ,prodotto "+prodotto+" ,divisione "+divisione);
            int perimetro = uno * 2 + due * 2;
            int areaUno = uno * due;
            Console.WriteLine("perimetro " + perimetro + " ,area " + areaUno);
            int b1 = 8;
            int b2 = 6;
            int areUn=(b1*b2)/2;
            Console.WriteLine("area " + areUn);
            int raggio = 8;
            float pi=3.14F;
            float circonf = raggio * 2 * pi;
            float areaCerchio = raggio * raggio * pi;
            Console.WriteLine("circonf: "+circonf+" area: " + areaCerchio);
           
            
        }
    }
}