using System.Collections.Generic;

namespace RomanNumerals
{
    /// <summary>
    /// Calculates the sum of roman numeric string.
    /// </summary>
    public class Calculator
    {
        private Dictionary<char, int> romanToValue = new Dictionary<char, int>{
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };

        /// <summary>
        /// Sums up the values of a normalized roman numeric.
        /// </summary>
        /// <param name="normalizedNumeral">The normalized roman numeric.</param>
        /// <returns>The sum of values</returns>
        /// <remark>The string must be normalized and should not contain IX IV XL XC CD CM.</remark>
        public int Sum(string normalizedNumeral) {
            int sum = 0;
            foreach(char romanNumeral in normalizedNumeral) {
                sum += romanToValue[romanNumeral];
            }
            return sum;
        }
    }
}