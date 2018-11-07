using System.Collections.Generic;

namespace RomanNumerals
{
    /// <summary>
    /// Replaces substraction in a roman numeric string
    /// </summary>
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

        /// <summary>
        /// Get the replacement roman numeric string for a roman numeric.
        /// </summary>
        /// <param name="romanNumeral">The roman numeric to replace.</param>
        /// <returns>The replacement string for <paramref="romanNumeral">.</returns>
        public string GetReplacement(string romanNumeral) {
            return replacements[romanNumeral];
        }

        /// <summary>
        /// Replaces all substractions in a roman numeric string.
        /// </summary>
        /// <param name="romanNumeral">The roman numeric string.</param>
        /// <returns>A string with replaced substractions.</returns>
        public string Replace(string romanNumeral) {
            string replacedNumeral = romanNumeral;
            foreach(var numeral in replacements) {
                replacedNumeral = replacedNumeral.Replace(numeral.Key, numeral.Value);
            }
            return replacedNumeral;
        }
    }
}