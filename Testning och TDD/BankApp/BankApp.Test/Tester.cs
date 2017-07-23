using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp;
using NUnit.Framework;

namespace BankApp.Test
{
    [TestFixture]
    public class Tester
    {
        [Test]
        public void TestDebit(
            [Values(1, 5, 10)]int x)
        {
            BankApp bankApp = new BankApp { Saldo = 10 };
            int input = x;
            bankApp.Debit(input);
            int expectedResult = 10 - x;
            int actualResult = bankApp.Balance();
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void TestCredit()
        {
            BankApp bankApp = new BankApp { Saldo = 10 };
            int input = 1;
            bankApp.Credit(input);
            int expectedResult = 11;
            int actualResult = bankApp.Balance();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestBalance()
        {
            BankApp bankApp = new BankApp { Saldo = 10 };
            int expectedResult = 10;
            int actualResult = bankApp.Balance();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OverDrawDebit(
            [Values(100, 1000, 10000)]int x)
        {
            BankApp bankApp = new BankApp { Saldo = 10 };
            bankApp.Debit(x);
            int expectedResult = 10;
            int actualResult = bankApp.Balance();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void InsertNegativeDebit(
            [Values(-10,-100)]int x)
        {
            BankApp bankApp = new BankApp { Saldo = 10 };
            bankApp.Debit(x);
            int expectedResult = 10;
            int actualResult = bankApp.Balance();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void InsertNegativeCredit(
            [Values(0, -10,-100)] int x)
        {
            BankApp bankApp = new BankApp { Saldo = 10 };
            bankApp.Credit(x);
            int expectedResult = 10;
            int actualResult = bankApp.Balance();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DebitMax1000()
        {
            BankApp bankApp = new BankApp { Saldo = 10000 };
            bankApp.Debit(5000);
            int expectedResult = 9000;
            int actualResult = bankApp.Balance();
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
