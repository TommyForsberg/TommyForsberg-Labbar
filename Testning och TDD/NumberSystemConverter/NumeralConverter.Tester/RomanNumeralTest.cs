using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NumberSystemConverter;


namespace NumeralConverter.Tester
{
    [TestFixture]
    public class RomanNumeralTest
    {
        RomanNumeralConverter converter;
        [OneTimeSetUp]
        public void InitializeConverter()
        {
            converter = new RomanNumeralConverter();
        }
        [Test]
        public void Input1GetI([Values(1)]
             int x)
        {
            var actual = converter.ConvertToRomanNumeral(x);
            var expected = "I";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Input5GetV([Values(5)]
             int x)
        {
            var actual = converter.ConvertToRomanNumeral(x);
            var expected = "V";
            Assert.AreEqual(expected, actual);
        }

        [Test,Sequential]
        public void InputMultipleIntGetCorrespondingString([Values( 10, 50, 100, 500, 1000 )]int x, [Values(  "X", "L", "C", "D", "M" )]string letter)
        {
            var actual = converter.ConvertToRomanNumeral(x);
            var expected = letter;
            Assert.AreEqual(expected, actual);
        }

        [Test,Sequential]
        public void InputHighNumberGetMultipleLetters([Values(580, 4560, 396, 956, 59,400,900)]int x, [Values("DLXXX", "MMMMDLX", "CCCXCVI", "CMLVI", "LIX", "CD", "CM")]string letter)
        {
            var actual = converter.ConvertToRomanNumeral(x);
            var expected = letter;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GiveNineGetCorrect()
        {
            var actual = converter.ConvertToRomanNumeral(9);
            var expected = "IX";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InputXXget20()
        {
            var actual = converter.ConvertToNumeral("XX");
            var expected = 20;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InputDCLXXVIIIget678()
        {
            var actual = converter.ConvertToNumeral("DCLXXVIII");
            var expected = 678;
            Assert.AreEqual(expected, actual);
        }

        [Test, Sequential]
        public void TestMultipleRomans([Values(678, 4560, 396, 956, 59, 400, 800, 999, 2489)]
        int x, [Values("DCLXXVIII", "MMMMDLX", "CCCXCVI", "CMLVI", "LIX", "CD", "DCCC", "CMXCIX", "MMCDLXXXIX")] string letter)
        {
            var actual = converter.ConvertToNumeral(letter);
            var expected = x;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InsertIVGet4()
        {
            var actual = converter.ConvertToNumeral("IV");
            var expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}
