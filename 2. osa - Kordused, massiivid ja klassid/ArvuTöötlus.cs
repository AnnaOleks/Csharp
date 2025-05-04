using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp._2._osa___Kordused__massiivid_ja_klassid
{
    internal class ArvuTöötlus
    {
        public static (int[] arvud, int[] ruudud) GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();
            int N = rnd.Next(min, max);
            int M = rnd.Next(min, max);

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);

            int arvudearv = end - start + 1;

            int[] arvud = new int[arvudearv];
            int[] ruudud = new int[arvudearv];

            for (int i = 0; i < arvudearv; i++)
            {

                int ruut = start + i;
                arvud[i] = start + i;
                ruudud[i] = ruut * ruut;
            }
            return (arvud, ruudud);
        }
        
    }
}
