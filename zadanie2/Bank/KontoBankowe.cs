using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class KontoBankowe
    {
        private string imie;
        private string nazwisko;
        private int numerKonta;
        private int fundusze;
        private int id;

        public KontoBankowe()
        { }

        public KontoBankowe(int fundusze)
        {
            this.fundusze = fundusze;
        }

        public KontoBankowe(string imie, string nazwisko, int numerKonta, int fundusze, int id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerKonta = numerKonta;
            this.fundusze = fundusze;
            this.id = id;
        }

        public int wyplacPieniadze(int fundusze)
        {
            if (fundusze < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (this.fundusze > fundusze)
                {
                    this.fundusze -= fundusze;
                    Console.WriteLine("Z konta o numerze {0} wypłacono {1} zł\n", numerKonta, fundusze);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            return this.fundusze;
        }

        public int wplacPieniadze(int fundusze)
        {
            if (fundusze < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Console.WriteLine("Na konto o numerze {0} wpłacono {1} zł\n", numerKonta, fundusze);
                this.fundusze += fundusze;
                return this.fundusze;
            }
        }

        public int sprawdzStanKonta()
        {
            Console.WriteLine("Na koncie {0} znajduje się {1} zł\n", numerKonta, fundusze);
            return fundusze;
        }

        public int przelejPieniadzeNaInneKonto(int fundusze, KontoBankowe konto)
        {
            if (fundusze < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Console.WriteLine("Z konta {0} na konto {1} przelano {2} zł\n", this.numerKonta, konto.numerKonta, fundusze);
                this.fundusze -= fundusze;
                konto.fundusze += fundusze;
                return fundusze;
            }
        }

    }
}