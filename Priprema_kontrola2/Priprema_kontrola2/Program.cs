using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_kontrola2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4;
            double b = 3;
            double c = 5;

            if(a<0 || b<0 || c<0)
            {
                Console.WriteLine("Svi brojevi moraju biti veći od nule.");
            }
            else if(Math.Pow(a,2) + Math.Pow(b,2)==Math.Pow(c,2))
            {
                Console.WriteLine("Trokut je pravokutan.");
            }
            else
            {
                Console.WriteLine("trokut nije pravokutan.");
            }

            Console.ReadKey();
        }
    }
}
