using System;
using System.Collections.Generic;
using static System.Console;

namespace Algebra_Boole_a.Programs
{
    /// <summary>
    /// Komparator 4 bitowy dwóch liczb binarnych
    /// </summary>
    internal static class Komparator
    {
        /// <summary>
        /// Menu
        /// </summary>
        public static void MainMenu()
        {
            Program.DisplayMenuTitle(2);

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
            DisplayFirst(1);
            string firstInput;
            while (true)
            {
                firstInput = ReadLine().Trim();
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
                Program.DisplayMenuTitle(2);

                SetCursorPosition(0, 15);
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Wprowadzono błędne dane!");
                ForegroundColor = ConsoleColor.White;
                Write("Podaj pierwszą cyfrę (");
                ForegroundColor = ConsoleColor.DarkRed;
                Write("binarną, czterobitową");
                ForegroundColor = ConsoleColor.White;
                Write("): ");
            }

            DisplayFirst(2, firstInput);
            string secondInput;
            while (true)
            {
                secondInput = ReadLine().Trim();
                if (secondInput.Length == 4)
                {
                    if (int.TryParse(secondInput, out _))
                    {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(secondInput, Addons.Constants.BinaryStringValidate()))
                        {
                            break;
                        }
                    }
                }

                Clear();
                Program.DisplayMenuTitle(2);
                SetCursorPosition(0, 13);
                WriteLine(firstInput + " ? ");
                WriteLine();

                SetCursorPosition(0, 15);
                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Wprowadzono błędne dane!");
                ForegroundColor = ConsoleColor.White;
                Write("Podaj drugą cyfrę (");
                ForegroundColor = ConsoleColor.DarkRed;
                Write("binarną, czterobitową");
                ForegroundColor = ConsoleColor.White;
                Write("): ");
            }

            Clear();
            Program.DisplayMenuTitle(2);

            int compare1 = Convert.ToInt32(firstInput, 2);
            int compare2 = Convert.ToInt32(secondInput, 2);

            SetCursorPosition(0, 13);
            if (compare1 > compare2)
            {
                WriteLine(firstInput + " > " + secondInput);

                SetCursorPosition(0, 15);
                WriteLine($"Wynik w systemie decymalnym: {compare1} > {compare2}");
            }
            else if (compare1 < compare2)
            {
                WriteLine(firstInput + " < " + secondInput);

                SetCursorPosition(0, 15);
                WriteLine($"Wynik w systemie decymalnym: {compare1} < {compare2}");
            }
            else
            {
                WriteLine(firstInput + " = " + secondInput);

                SetCursorPosition(0, 15);
                WriteLine($"Wynik w systemie decymalnym: {compare1} = {compare2}");
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
        /// Wyświetla ponowny test
        /// </summary>
        /// <param name="x">Numer cyfry input</param>
        /// <param name="firstBinary">pierwszy input</param>
        private static void DisplayFirst(int x, string firstBinary = null)
        {
            Clear();
            Program.DisplayMenuTitle(2);

            if (x == 1)
            {
                SetCursorPosition(0, 16);
                Write("Podaj pierwszą cyfrę: ");
            }
            else if (x == 2)
            {
                SetCursorPosition(0, 13);
                WriteLine(firstBinary + " ? ");

                SetCursorPosition(0, 16);
                Write("Podaj drugą cyfrę: ");
            }
        }

        /// <summary>
        /// Wszystkie możliwośći
        /// </summary>
        private static void AllPossibilities()
        {
            int parity = 0;
            int trials = 0;
            List<string> binary = Addons.Constants.BinaryInput();

            Program.DisplayMenuTitle(2);
            WriteLine();

            foreach (string variable in binary)
            {
                int baseOfCompare = Convert.ToInt32(variable, 2);
                for (int i = 0; i < binary.Count; i++)
                {
                    int foreignCompare = Convert.ToInt32(binary[i], 2);

                    ForegroundColor = parity % 2 == 0 ? ConsoleColor.DarkGreen : ConsoleColor.DarkCyan;

                    Write(Convert.ToString(baseOfCompare, 2).PadLeft(4, '0'));

                    if (baseOfCompare > foreignCompare)
                        Write(" > " + Convert.ToString(foreignCompare, 2).PadLeft(4, '0'));
                    else if (baseOfCompare < foreignCompare)
                        Write(" < " + Convert.ToString(foreignCompare, 2).PadLeft(4, '0'));
                    else
                        Write(" = " + Convert.ToString(foreignCompare, 2).PadLeft(4, '0'));

                    trials++;
                    WriteLine();
                    WriteLine();
                }
                parity++;
            }
            ForegroundColor = ConsoleColor.White;
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