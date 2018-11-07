using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Tests
{
    [TestClass]
    public class ReplacerTests
    {
        private Replacer replacer;

        [TestInitialize]
        public void Initialize() {
            this.replacer = new Replacer();
        }

        [DataTestMethod]
        [DataRow("IV", "IIII")]
        [DataRow("IX", "VIIII")]
        [DataRow("XL", "XXXX")]
        [DataRow("XC", "LXXXX")]
        [DataRow("CD", "CCCC")]
        [DataRow("CM", "DCCCC")]
        public void GetReplacementValidStrings(string roman, string replacement) {
            string actual = this.replacer.GetReplacement(roman);
            Assert.AreEqual(replacement, actual);
        }

        [DataTestMethod]
        [DataRow("I")]
        [DataRow("V")]
        [DataRow("X")]
        [DataRow("L")]
        [DataRow("C")]
        [DataRow("D")]
        [DataRow("M")]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void GetReplacementInvalidStrings(string roman) {
            string actual = this.replacer.GetReplacement(roman);
            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void ReplaceIVIsReplaced() {
            string actual = this.replacer.Replace("XIV");
            Assert.AreEqual("XIIII", actual);
        }

        [TestMethod]
        public void ReplaceIXIsReplaced() {
            string actual = this.replacer.Replace("DIX");
            Assert.AreEqual("DVIIII", actual);
        }

        [TestMethod]
        public void ReplaceXLIsReplaced() {
            string actual = this.replacer.Replace("MXLIII");
            Assert.AreEqual("MXXXXIII", actual);
        }
    }
}
