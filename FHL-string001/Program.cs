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

            string sterne = new string('*', 15);
            Console.WriteLine(sterne);

//            int X = 5;
//            string s10 = new string(X, 10);
//            Console.WriteLine(s10);


            string gesamtG = gesamtstring.ToUpper();
            Console.WriteLine(gesamtG);

            string gesamt_string = "Hier ist ein anderer Text versteckt";
            if (gesamt_string.Contains("versteckt") == true)
            {
                Console.WriteLine("Teilstring gefunden !");
            }
            else
            {
                Console.WriteLine("Teilstring nicht gefunden !");
            }

            gesamtG.Replace("MICHAEL", "Otto");
            Console.WriteLine(gesamtG);

            gesamtG = gesamtG.Replace("MICHAEL", "Otto");
            Console.WriteLine(gesamtG);

            string test = "1234567890";
            int anzahl = test.Length;
            Console.WriteLine("Die Länge des strings beträgt: " + anzahl);

            string fh = "Einführung in die Programmierung";
            int first_idx = fh.IndexOf('f');
            Console.WriteLine("Das erste 'f' wurde gefunden an der Stelle " + first_idx);
            int last_idx = fh.LastIndexOf('i');
            Console.WriteLine("Das letzte 'i' wurde gefunden an :" + last_idx);

            string vergl1 = "abcdef";
            string vergl2 = "abcdef";
            int vergleich = vergl1.CompareTo(vergl2);
            //int vergleich = a.CompareTo("1234");
            if (vergleich == 0) Console.WriteLine(vergl1 + " und " + vergl2 + " sind gleich");
            else Console.WriteLine(vergl1 + " und " + vergl2 + " sind ungleich");

            vergl2 = "abcde";
            bool vergleich2 = vergl1.Equals(vergl2);
            if (vergleich2 == true) Console.WriteLine(vergl1 + " und " + vergl2 + " sind gleich");
            else Console.WriteLine(vergl1 + " und " + vergl2 + " sind ungleich");


            string[] gesplittet = fh.Split(' ');
            foreach (string item in gesplittet)
            {
                Console.WriteLine(item);
            }

            string fh_leibniz = fh.Insert(0, "Leibniz FH - ");
            Console.WriteLine(fh_leibniz);

            string removed = fh_leibniz.Remove(0, 8);
            Console.WriteLine(removed);

            int temperatur = 20;
            string temp_s = temperatur.ToString();


            string notiz = "Viele Berge sind heute hinter vielen Wolken versteckt.";
            // Remove a substring from the middle of the string.
            string such = "vielen ";
            // string result = "";
            // is the same:
            // string result = string.Empty;
            string result = null;
            // int len = result.Length;
            // Console.WriteLine("result hat die Länge " + len);
            int i = notiz.IndexOf(such);
            if (i >= 0)
            {
                result = notiz.Remove(i, such.Length);
            }
            else
            {
                result = notiz;
            }
            Console.WriteLine(notiz);
            Console.WriteLine(result);


            /*
                        string nachricht = "Neue Nachricht";
                        string name2 = "Helga";
            // ERROR            name2.Append(" hat eine Nachricht bekommen: ");
            // ERROR            name2.Append(nachricht);
            */


            Console.ReadKey();
        }
    }
}
