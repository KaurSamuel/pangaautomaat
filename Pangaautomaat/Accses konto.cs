using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangaautomaat
{
    class Accses_konto : andmed
    {
        public static void Sisene_konto()
        {
            start:
            Console.WriteLine("Mis on teie konto kasutajanimi?");
            string nimi = Console.ReadLine();
            var sisselogitud_konto = new andmed();
            sisselogitud_konto.Directorypath = nimi + ".txt";           
            if (System.IO.File.Exists(sisselogitud_konto.Directorypath))
            {
                string[] read = System.IO.File.ReadAllLines(sisselogitud_konto.Directorypath);
                Console.WriteLine("sisestage oma konto parool");
                string pin = Console.ReadLine();
                if (pin == read[0])
                {
                    Console.WriteLine("Õige parool!");
                    kontos.Sisse_logitud(sisselogitud_konto.Directorypath);
                }
                else
                {
                    Console.WriteLine("VALE PAROOL!");
                    
                }
                
            }
            else
            {
                Console.WriteLine("sellist kontot pole olemas");
            }
            
        }
    }
}
