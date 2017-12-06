using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangaautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Tere! Mida te teha tahate? Regristeeruda/Logida sisse(r/l)");
            string valik = Console.ReadLine();          
            if (valik== "r")
            {
                Luua_konto.Konto_luua();
            }
            else if (valik== "l")
            {
                Accses_konto.Sisene_konto();
            }
            else
            {
                Console.WriteLine("sellist valikut pole olemas");
                goto start;
            }
            goto start;
        }
    }
}
