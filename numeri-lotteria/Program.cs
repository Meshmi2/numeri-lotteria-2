using System;
using System.Threading;
namespace numerilotteria
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            int inizio = 1;
            int fine = 90;
            Random random = new Random();
            int numeroCasuale1 = random.Next(inizio, fine);
            int numeroCasuale2 = random.Next(inizio, fine);
            int numeroCasuale3 = random.Next(inizio, fine);
            int numeroCasuale4 = random.Next(inizio, fine);
            int numeroCasuale5 = random.Next(inizio, fine);
            int numeroCasuale6 = random.Next(inizio, fine);

            int numeroCasuales = random.Next(inizio, fine);
            string line;
            {
                Console.Write("Gioca Questi Numeri:) Buona Fortuna ;)");
                line = Console.ReadLine();

                Thread.Sleep(1500);
                Console.WriteLine("primo numero   " + numeroCasuale1);
                Thread.Sleep(1500);
                Console.WriteLine("secondo numero   " + numeroCasuale2);
                Thread.Sleep(1500);
                Console.WriteLine("terzo numero   " + numeroCasuale3);
                Thread.Sleep(1500);
                Console.WriteLine("quarto numero   " + numeroCasuale4);
                Thread.Sleep(1500);
                Console.WriteLine("quinto numero   " + numeroCasuale5);
                Thread.Sleep(1500);
                Console.WriteLine("sesto numero   " + numeroCasuale6);
                Thread.Sleep(1500);
                Console.WriteLine("numero star   " + numeroCasuales);
            }
        }
    }
}