using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace Bank.Tests
{
    [TestFixture]
    public class BankTests
    {
        #region Wypłata
        [Test]
        public void Wyplata_WyplataDodatniejKwoty()
        {
            var bank = new KontoBankowe(500);
            int wyplac = bank.wyplacPieniadze(200);
            Assert.AreEqual(300, wyplac);
        }

        [Test]
        public void Wyplata_WyplataUjemnejKwoty()
        {
            var bank = new KontoBankowe(500);
            Assert.Throws<ArgumentOutOfRangeException>(() => bank.wyplacPieniadze(-100));
        }

        [Test]
        public void Wyplata_WyplataKwotyWiekszejNizSaldoKonta()
        {
            var bank = new KontoBankowe(500);
            Assert.Throws<ArgumentOutOfRangeException>(() => bank.wyplacPieniadze(1000));
        }

        #endregion
        #region Wpłata
        [Test]
        public void Wplata_WplataDodatniejKwoty()
        {
            var bank = new KontoBankowe(500);
            int wplac = bank.wplacPieniadze(100);
            Assert.AreEqual(600, wplac);
        }

        [Test]
        public void Wplata_WplataUjemnejKwoty()
        {
            var bank = new KontoBankowe();
            Assert.Throws<ArgumentOutOfRangeException>(() => bank.wplacPieniadze(-100));
        }
        #endregion
        #region Sprawdzanie stanu konta
        [Test]
        public void SprawdzanieStanuKonta_StanKonta()
        {
            var bank = new KontoBankowe(500);
            Assert.AreEqual(500, bank.sprawdzStanKonta());
        }

        #endregion
        #region Transfer pieniędzy między dwoma obiektami

        [Test]
        public void Transfer_PrzelanieDodatniejSumy()
        {
            var bank = new KontoBankowe();
            Assert.AreEqual(100, bank.przelejPieniadzeNaInneKonto(100, bank));
        }

        [Test]
        public void Transfer_PrzelanieUjemnejSumy()
        {
            var bank = new KontoBankowe();
            Assert.Throws<ArgumentOutOfRangeException>(() => bank.przelejPieniadzeNaInneKonto(-100, bank));
        }
        
        #endregion
    
    }
}
