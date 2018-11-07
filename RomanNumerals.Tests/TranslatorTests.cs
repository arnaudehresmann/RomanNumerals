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
    }
}
