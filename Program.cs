using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszerek
{
    internal class Program
    {
        public static int szamolas()
        {
            int szam = 0;
            Console.WriteLine($"Kérem az átváltandó számot: ");
            szam = szam % 2;
            return szam;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(szamolas());
            Console.ReadKey();
        }

    }
}
