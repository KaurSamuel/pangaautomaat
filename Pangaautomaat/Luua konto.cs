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

            Console.WriteLine("Mis kavatseb olla teie konto kasutajanimi?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Mis kavatseb olla teie konto parool?");
            string pin = Console.ReadLine();     
            var uus_konto = new andmed();
            uus_konto.Nimi = nimi;
            uus_konto.PIN = pin;
            uus_konto.Directorypath = nimi + ".txt";
            if (!System.IO.File.Exists(uus_konto.Directorypath))
            {
                System.IO.File.WriteAllText(uus_konto.Directorypath, pin);

                Console.WriteLine("konto "+ uus_konto.Nimi+"loodi");
            }
            else
            {
                Console.WriteLine("konto "+ uus_konto.Nimi+ " on juba olemas");             
            }
            Console.ReadLine();
        }
    }
}
