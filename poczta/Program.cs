using System;

namespace poczta
{
    class Program
    {
        static void Main(string[] args)
        {
            WlasciwosciOkna.UstawienieOkna();

            RysowanieKolejek R = new RysowanieKolejek();
            R.Rysowanie();

            Console.ReadKey(true);
        }
    }
}
