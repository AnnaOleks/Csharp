using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._4._osa___Kollektsioonid._Listid_ja_sõnastikud
{
    internal class Film
    {
        public string Pealkiri { get; set; }
        public int Aasta { get; set; }
        public string Zanr { get; set; }

        public Film(string pealkiri, int aasta, string žanr)
        {
            Pealkiri = pealkiri;
            Aasta = aasta;
            Zanr = žanr;
        }
        public string Info()
        {
            return Pealkiri + " (" + Aasta + ") - Žanr: " + Zanr;
        }
    }
}
