using System;

namespace Sconti2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il totale della spesa");
            double tot = double.Parse(Console.ReadLine());
            double sconto = (tot * 10) / 100;
            double sconto2 = (tot * 20) / 100;
            if (tot <= 500)
            {
                double importo = tot - sconto;
                Console.WriteLine($"l'importo totale è {importo:c}");
            }
            if (tot > 500)
            {
                double importo = tot - sconto2;
                Console.WriteLine($"l'importo totale è {importo:c}");
            }
            Console.ReadLine();
        }
    }
}
