using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe konto1 = new KontoBankowe("Kamil", "Kozak", 12345, 500, 1);
            KontoBankowe konto2 = new KontoBankowe("Maciej", "Bąk", 98765, 100, 2);
            konto1.sprawdzStanKonta();
            konto2.sprawdzStanKonta();
            Console.WriteLine("-----------------------------------------");
            konto1.wplacPieniadze(100);
            konto1.wyplacPieniadze(300);
            konto2.wplacPieniadze(100);
            Console.WriteLine("-----------------------------------------");
            konto1.sprawdzStanKonta();
            konto2.sprawdzStanKonta();
            Console.WriteLine("-----------------------------------------");
            konto1.przelejPieniadzeNaInneKonto(100, konto2);
            konto1.sprawdzStanKonta();
            konto2.sprawdzStanKonta();

            Console.ReadLine();
        }
    }
}
