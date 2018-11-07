using System;

namespace RomanNumerals
{
    /// <summary>
    /// Translates a roman numeric string to an arabic number.
    /// </summary>
    public class Translator
    {
        /// <summary>
        /// Converts a roman numeric string to an arabic number.
        /// </summary>
        /// <param name="romanString">The roman string.</param>
        /// <returns>The converted roman string.</returns>
        public int ToArabic(string romanString) {
            /* we replace IV IX XL XC CD and CM substraction by their "sums" IIII or VIIII */
            string normalizedString = new Replacer().Replace(romanString);
            return new Calculator().Sum(normalizedString);
        }
    }
}
