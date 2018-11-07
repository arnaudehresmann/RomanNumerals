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
            string replacedNumeral = romanNumeral.Replace("IV", this.GetReplacement("IV"));
            replacedNumeral = replacedNumeral.Replace("IX", this.GetReplacement("IX"));
            replacedNumeral = replacedNumeral.Replace("XL", this.GetReplacement("XL"));
            return replacedNumeral;
        }
    }
}