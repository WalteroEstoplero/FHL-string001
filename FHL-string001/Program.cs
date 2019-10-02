using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHL_string001
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aaa";
            String b = "bbb";
            string hallo = "Hallo!";
            int len_hallo = hallo.Length;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("hallo hat die Länge " + len_hallo);

            string hello = "Hello ";
            string name = "Michael";
            string gesamtstring = hello + name;
            Console.WriteLine(gesamtstring);

            string gesamtG = gesamtstring.ToUpper();
            Console.WriteLine(gesamtG);

            gesamtG.Replace("MICHAEL", "Otto");
            Console.WriteLine(gesamtG);

            gesamtG = gesamtG.Replace("MICHAEL", "Otto");
            Console.WriteLine(gesamtG);


            Console.ReadKey();
        }
    }
}
