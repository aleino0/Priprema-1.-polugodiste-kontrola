using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_kontrola1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");
            string niz = Console.ReadLine();

            if(niz.Length<5)
            {
                Console.WriteLine(niz);
            }
            else
            {
                Console.WriteLine(niz.Substring(2, niz.Length - 4));
            }
           

            Console.ReadKey();
        }
    }
}
