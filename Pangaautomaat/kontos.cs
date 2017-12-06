using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangaautomaat
{
    class kontos : andmed
    {       
        public static int Sisse_logitud(string Directorypath)
        {
            start:
            Console.WriteLine("mida te teha tahate? 1.raha välja võtta/2.raha laadida/3.kontojääk/4.logida välja");
            int valik = int.Parse(Console.ReadLine());
            string[] read = System.IO.File.ReadAllLines(Directorypath);            
            if (valik == 1)
            {
                Console.WriteLine("mitu eurot te tahate välja võta?");
                decimal raha = decimal.Parse(Console.ReadLine());
                decimal kuipalju = decimal.Parse(read[1]);
                if (raha> kuipalju)
                {
                    Console.WriteLine("teil pole piisavalt raha");
                    goto start;
                }
                decimal kuipaljuon = decimal.Parse(read[1]);
                decimal vastus = kuipaljuon - raha;
                read[1] = String.Format("{0:G}", vastus);
                System.IO.File.WriteAllLines(Directorypath, read);
                goto start;
            }
            else if (valik== 2)
            {              
                Console.WriteLine("mitu eurot te tahate laadida?");
                decimal raha = decimal.Parse(Console.ReadLine());
                decimal vastus = decimal.Parse(read[1]+raha);
                read[1] = String.Format("{0:G}", vastus);
                System.IO.File.WriteAllLines(Directorypath, read);
                goto start;
            }
            else if (valik == 3)
            {                
                Console.WriteLine("teie kontol on "+ read[1]+ " eurot");
                goto start;
            }
            else if (valik== 4)
            {
                
            }
            else
            {
                Console.WriteLine("sellist valikut pole olemas");
                goto start;
            }
            return(0);
        }
    }
}
