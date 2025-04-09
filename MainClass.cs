using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World");
            //I.osa Andmetuubid, if, case, random, alamfunktsioonid
            /* многострочный комментарий
             * 
             */
            int a = 0;
            string tekst = "Python";
            char taht = 'A';
            double arv = 5.4568685;
            float arv1 = 2;
            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere!\n" + tekst);
            // Console.WriteLine("{1} Tere!\n{0}", tekst, arv); //индекс прописывается по местоположению перемнной после запятой
            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Laheme kinno!");
                try
                {
                    Console.WriteLine("{0}\n Kui vana sa oled?", tekst);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100) // "|| - OR", "&& - AND"
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus > 0 && vanus <= 6)
                    {
                        Console.WriteLine("Tasuta");
                    }
                    else if (vanus < 15)
                    {
                        Console.WriteLine("Lastepilet");
                    }
                    else if (vanus < 65)
                    {
                        Console.WriteLine("Täispilet");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Olen hoivatud!");
            }


            //Console.WriteLine("Arv 2: ");
            //int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Arvude {0} ja {1} korrutis vordub {2}", arv1, arv2, arv1 * arv2);
            //arv1 = Funktsioonid.Kalkulaator(a, arv2);
            //Console.WriteLine(arv1);
            Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("Switchi kasutamine");
            tekst = Funktsioonid.switchkas(tekst);
            Console.WriteLine(tekst);
            Console.ReadLine();
        }
    }
}
