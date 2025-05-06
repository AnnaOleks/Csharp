using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._4._osa___Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Opilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public Opilane(string nimi, List<int> hinded)
        {
            Nimi = nimi;
            Hinded = hinded;
        }

        public double KeskmineHinne()
        {
            return Math.Round(Hinded.Average(),2);
        }
    }
}
