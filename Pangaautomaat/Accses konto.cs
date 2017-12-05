using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangaautomaat
{
    class Accses_konto
    {
        public static void Sisene_konto()
        {
            Console.WriteLine("Mis on teie konto kasutajanimi?");
            string nimi = Console.ReadLine();
            string Directorypath = nimi + ".txt";
            Console.WriteLine(Directorypath);
            if (!System.IO.File.Exists(Directorypath))
            {
                string[] read = System.IO.File.ReadAllLines("proov.txt.txt");
                Console.WriteLine("sisestage oma konto parool");
                string pin = Console.ReadLine();                
                if (pin == read[0])
                {
                    Console.WriteLine("Õige parool!");
                }
                else
                {
                    Console.WriteLine("VALE PAROOL!");
                }
            }
            else
            {
                Console.WriteLine("SELLIST KONTOT POLE OLEMAS!");
            }
            Console.ReadLine();
        }
    }
}
