using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide.Tests
{
    [TestFixture]
    class DivideTests
    {
        [Test]
        public void Devide_DevideTwoPositiveNumbers()
        {
            var calc = new Divide();
            double div = calc.DivideNumbers(20, 5);
            Assert.AreEqual(4, div);
        }
        [Test]
        public void Devide_DevideTwoNegativeNumbers()
        {
            var calc = new Divide();
            double div = calc.DivideNumbers(-20, -5);
            Assert.AreEqual(4, div);
        }
        [Test]
        public void Devide_DevidePositiveNumberByNegativeNumber()
        {
            var calc = new Divide();
            double div = calc.DivideNumbers(20, -5);
            Assert.AreEqual(-4, div);
        }
        [Test]
        public void Devide_DevideNegativeNumberByPositiveNumbers()
        {
            var calc = new Divide();
            double div = calc.DivideNumbers(-20, 5);
            Assert.AreEqual(-4, div);
        }
        [Test]
        public void Devide_DevideZeroByPositiveNumbers()
        {
            var calc = new Divide();
            double div = calc.DivideNumbers(0, 5);
            Assert.AreEqual(0, div);
        }
        [Test]
        public void Devide_DevidePositiveNumbersByZero()
        {
            var calc = new Divide();
            Assert.Throws<DivideByZeroException>(() => calc.DivideNumbers(20, 0));
        }
    }
}
