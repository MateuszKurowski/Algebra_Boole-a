using System;
using static System.Console;

namespace Algebra_Boole_a.Programs
{
    /// <summary>
    /// Przekazuje informacje o autorze
    /// </summary>
    class Autor
    {
        /// <summary>
        /// Główne menu klasy Autor
        /// </summary>
        public static void Menu()
        {
            Clear();
            Program.DisplayMenuTitle(0);
            WindowWidth = 80;
            WriteLine("Autor:");

            SetCursorPosition((10 / 2), 13);
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Imię: ");
            SetCursorPosition((27 / 2), 13);
            ForegroundColor = ConsoleColor.White;
            Write("Mateusz");

            SetCursorPosition((10 / 2), 14);
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Nazwisko: ");
            SetCursorPosition((30 / 2), 14);
            ForegroundColor = ConsoleColor.White;
            Write("Kurowski");

            SetCursorPosition((10 / 2), 15);
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Numer albumu: ");
            SetCursorPosition((40 / 2), 15);
            ForegroundColor = ConsoleColor.White;
            Write("13424");

            SetCursorPosition((10 / 2), 16);
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Uczelnia: ");
            SetCursorPosition((33 / 2), 16);
            ForegroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.DarkGreen;
            Write("(WSEI)");
            ForegroundColor = ConsoleColor.White;
            Write(" Wyższa Szkoła Ekonomii i Informatyki w Krakowie");

             
            WriteLine();
            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Naciśnij dowolny przycisk by wrócić do menu głównego.");
            ForegroundColor = ConsoleColor.White;

            ReadKey();
            Program.Main();
        }
    }
}
