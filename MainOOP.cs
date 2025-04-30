using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MainOOP
    {
        public class Inimene
        {
            public string Nimi;
            public int Vanus;

            public void Tervita()
            {
                Console.WriteLine("Tere! Mina olen " + Nimi);
            }
        }
        public class Töötaja : Inimene
        {
            public string Ametikoht;

            public void Töötan()
            {
                Console.WriteLine($"{Nimi} töötab ametikohal {Ametikoht}.");
            }
        }
    }
}
