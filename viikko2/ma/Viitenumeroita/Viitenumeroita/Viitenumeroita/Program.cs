using System;

namespace Viitenumeroita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna laskunumero:");
            string laskunro = Console.ReadLine();
            Console.WriteLine("Anna laskunumeron kasvatusnro:");
            int kasvatusnro = int.Parse(Console.ReadLine());
            Console.WriteLine("Montako viitenumeroa haluaisit tulostaa?");
            int tulostusmäärä = int.Parse(Console.ReadLine());
            Console.WriteLine(Viitenumero.Laskeviite(laskunro, kasvatusnro, tulostusmäärä));
            
        }
    }
}
