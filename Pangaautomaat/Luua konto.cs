using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangaautomaat
{
    class Luua_konto
    {
        public static void Konto_luua()
        {
            start:
            Console.WriteLine("Mis kavatseb olla teie konto kasutajanimi?");
            string nimi = Console.ReadLine();
            if (nimi=="")
            {
                Console.WriteLine("palun kirjutage midagi");
                goto start;
            }
            Console.WriteLine("Mis kavatseb olla teie konto parool?");
            string pin = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Mis kavatseb olla teie konto parool?");
                pin = Console.ReadLine();
                if (pin=="")
                {
                    Console.WriteLine("palun kirjutage midagi");
                }
                else
                {
                    break;
                }
            }           
            var uus_konto = new andmed();
            uus_konto.Nimi = nimi;
            uus_konto.PIN = pin;
            uus_konto.Directorypath = nimi + ".txt";
            if (!System.IO.File.Exists(uus_konto.Directorypath))
            {
                string raha ="0";
                string[] lines = { uus_konto.PIN, raha };
                System.IO.File.WriteAllLines(uus_konto.Directorypath, lines);
                Console.WriteLine("konto "+ uus_konto.Nimi+" loodi");               
            }
            else
            {
                Console.WriteLine("konto "+ uus_konto.Nimi+ " on juba olemas");             
            }
            
        }
    }
}
