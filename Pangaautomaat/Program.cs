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
            Console.WriteLine("Tere! Mida te teha tahate? Luua konto/Raha välja võta/Kontojääk");
            string valik = Console.ReadLine();
            if (valik == "Raha välja võta")
            {
                Accses_konto.Sisene_konto();
            }
            if (valik== "Luua konto")
            {
                Luua_konto.Konto_luua();
            }
            if (valik== "Kontojääk")
            {
                Accses_konto.Sisene_konto();
            }

        }

    }
}
