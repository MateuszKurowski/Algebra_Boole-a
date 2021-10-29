using System.Collections.Generic;

namespace Algebra_Boole_a.Addons
{
    /// <summary>
    /// Zwraca stałe
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Zwraca listę wszystkich możliwości na 4 bitach
        /// </summary>
        /// <returns>Lista wynikó 4 bitów</returns>
        public static List<string> BinaryInput()
        {
            return new List<string>()
            {
                "0000",
                "0001",
                "0010",
                "0011",
                "0100",
                "0101",
                "0110",
                "0111",
                "1000",
                "1001",
                "1010",
                "1011",
                "1100",
                "1101",
                "1110",
                "1111"
            };
        }

        /// <summary>
        /// Lista kontrolna cyfr poza 0 lub 1
        /// </summary>
        /// <returns>Lista kontrolna w psotaci wyrażenia string</returns>
        public static string BinaryStringValidate()
        {
            return "[2-9]+";
        }
    }
}