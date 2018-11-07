using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class TranslatorTests
    {
        private Translator translator;

        [TestInitialize]
        public void Initialize() {
            this.translator = new Translator();
        }

        [TestMethod]
        public void ToArabicIReturns1() {
            int actual = this.translator.ToArabic("I");
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void ToArabicIIReturns2() {
            int actual = this.translator.ToArabic("II");
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void ToArabicIVReturns4() {
            int actual = this.translator.ToArabic("IV");
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void ToArabicVReturns5() {
            int actual = this.translator.ToArabic("V");
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void ToArabicIXReturns9() {
            int actual = this.translator.ToArabic("IX");
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void ToArabicXLIIReturns42() {
            int actual = this.translator.ToArabic("XLII");
            Assert.AreEqual(42, actual);
        }

        [TestMethod]
        public void ToArabicXCIXReturns99() {
            int actual = this.translator.ToArabic("XCIX");
            Assert.AreEqual(99, actual);
        }

        [TestMethod]
        public void ToArabicMMXIIIReturns2013() {
            int actual = this.translator.ToArabic("MMXIII");
            Assert.AreEqual(2013, actual);
        }
    }
}
