using System.Collections.Generic;

namespace RomanNumerals
{
    public class Replacer
    {
        private Dictionary<string, string> replacements = new Dictionary<string, string>(){
            {"IV", "IIII"},
            {"IX", "VIIII"},
            {"XL", "XXXX"},
            {"XC", "LXXXX"},
            {"CD", "CCCC"},
            {"CM", "DCCCC"}
        };

        public string GetReplacement(string romanNumeral) {
            return replacements[romanNumeral];
        }

        public string Replace(string romanNumeral) {
            string replacedNumeral = romanNumeral;
            foreach(var numeral in replacements) {
                replacedNumeral = replacedNumeral.Replace(numeral.Key, numeral.Value);
            }
            return replacedNumeral;
        }
    }
}