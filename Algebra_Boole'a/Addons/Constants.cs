using System.Collections.Generic;

namespace Algebra_Boole_a.Addons
{
    /// <summary>
    /// Zwraca stałe
    /// </summary>
    class Constants
    {
        /// <summary>
        /// Zwraca listę wszystkich możliwości na 4 bitach
        /// </summary>
        /// <returns>Lista wynikó 4 bitów</returns>
        public List<int> BinaryInput()
        {
            return new List<int>()
            {
                0000,
                0001,
                0010,
                0011,
                0100,
                0101,
                0110,
                0111,
                1000,
                1001,
                1010,
                1011,
                1100,
                1101,
                1110,
                1111
            };
        }
    }
}
