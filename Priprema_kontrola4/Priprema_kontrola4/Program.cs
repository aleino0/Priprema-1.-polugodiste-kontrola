using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_kontrola4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a");
            double bezPDV=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite cijenu sa PDV-a");
            double saPDV = Convert.ToDouble(Console.ReadLine());


            if (bezPDV > saPDV)
            {
                Console.WriteLine("Neispravan unos cijena.");
            }
            else
            {
                Console.WriteLine("PDV= {0} % ", ((saPDV - bezPDV) / bezPDV * 100));
            }

            Console.ReadKey();
        }
    }
}
