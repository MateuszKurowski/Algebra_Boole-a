using System;
using System.Collections.Generic;
using static System.Console;

namespace Algebra_Boole_a.Programs
{
    /// <summary>
    /// Sprawdza czy liczba binarna 4 bitowa jest parzysta i pokazuje w 5 bicie parzystość
    /// </summary>
    internal static class KontrolerParzystosci
    {
        /// <summary>
        /// Menu
        /// </summary>
        public static void MainMenu()
        {
            Program.DisplayMenuTitle(3);

            WindowWidth = 80;
            SetCursorPosition(70 / 2, 12);
            WriteLine("Menu");
            SetCursorPosition(30 / 2, 14);
            WriteLine("1. Ręczny test.");
            SetCursorPosition(30 / 2, 15);
            WriteLine("2. Wszystkie możliwości.");
            SetCursorPosition(30 / 2, 16);
            WriteLine("3. Powrót.");

            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey keyPressed = keyInfo.Key;

            switch (keyPressed)
            {
                case ConsoleKey.D1:
                    ManualTest();
                    break;

                case ConsoleKey.D2:
                    AllPossibilities();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.Escape:
                    Program.Main();
                    break;
            }
            MainMenu();
        }

        /// <summary>
        /// Test ręczny
        /// </summary>
        public static void ManualTest()
        {
            Program.DisplayMenuTitle(3);

            SetCursorPosition(0, 13);
            Write("Podaj cyfrę do sprawdzenia parzystości: ");

            string firstInput;
            while (true)
            {
                firstInput = ReadLine();
                if (firstInput.Length == 4)
                {
                    if (int.TryParse(firstInput, out _))
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(firstInput, Addons.Constants.BinaryStringValidate()))
                        {
                            break;
                        }
                    }
                }

                Clear();
                Program.DisplayMenuTitle(3);

                SetCursorPosition(0, 12);
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Wprowadzono błędne dane!");
                ForegroundColor = ConsoleColor.White;
                Write("Podaj cyfrę do sprawdzenia parzystości (");
                ForegroundColor = ConsoleColor.DarkRed;
                Write("binarną, czterobitową");
                ForegroundColor = ConsoleColor.White;
                Write("): ");
            }

            Clear();
            Program.DisplayMenuTitle(3);

            int parity = Convert.ToInt32(firstInput, 2);

            if (parity % 2 == 0)
            {
                SetCursorPosition(0, 11);
                Write(firstInput);
                ForegroundColor = ConsoleColor.Red;
                WriteLine(" 1");
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine($"Liczba {parity} jest parzysta!");
            }
            else
            {
                SetCursorPosition(0, 11);
                Write(firstInput);
                ForegroundColor = ConsoleColor.Red;
                WriteLine(" 0");
                ForegroundColor = ConsoleColor.White;
                WriteLine();
                WriteLine($"Liczba {parity} jest nieparzysta!");
            }

            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Naciśnij dowolny klawisz by wrócić do menu głównego.");
            ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Program.Main();
        }

        /// <summary>
        /// Wszystkie możliwości
        /// </summary>
        private static void AllPossibilities()
        {
            int trials = 0;
            List<string> binary = Addons.Constants.BinaryInput();

            Program.DisplayMenuTitle(3);
            WriteLine();

            foreach (string variable in binary)
            {
                int baseCompare = Convert.ToInt32(variable, 2);
                Write(variable);

                if (baseCompare % 2 == 0)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine(" 1");
                    ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine(" 0");
                    ForegroundColor = ConsoleColor.White;
                }

                WriteLine();
                trials++;
            }
            WriteLine("-----------------------------");

            if (trials == 1)
                WriteLine($"Wykonano: {trials} raz!");
            else
                WriteLine($"Wykonano: {trials} razy!");

            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("Naciśnij dowolny klawisz by wrócić do menu głównego.");
            ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Program.Main();
        }
    }
}