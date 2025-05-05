using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._2._osa___Kordused__massiivid_ja_klassid
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Statistika(List<Inimene> inimesed)
        {

            
        }
    }
}
