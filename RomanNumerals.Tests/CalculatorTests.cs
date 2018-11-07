using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Initialize() {
            this.calculator = new Calculator();
        }

        [TestMethod]
        public void SumReturns1ForI() {
            int actual = this.calculator.Sum("I");
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void SumReturns5ForV() {
            int actual = this.calculator.Sum("V");
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void SumReturns10ForX() {
            int actual = this.calculator.Sum("X");
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void SumReturns50ForL() {
            int actual = this.calculator.Sum("L");
            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void SumReturns100ForC() {
            int actual = this.calculator.Sum("C");
            Assert.AreEqual(100, actual);
        }

        [TestMethod]
        public void SumReturns500ForD() {
            int actual = this.calculator.Sum("D");
            Assert.AreEqual(500, actual);
        }

        [TestMethod]
        public void SumReturns1000ForM() {
            int actual = this.calculator.Sum("M");
            Assert.AreEqual(1000, actual);
        }

        public void SumIIIReturns3(){
            int actual = this.calculator.Sum("III");
            Assert.AreEqual(3, actual);
        }

        public void SumMMMDCCCLXVIIIReturns3868(){
            int actual = this.calculator.Sum("MMMDCCCLXVIII");
            Assert.AreEqual(3868, actual);
        }
    }
}
