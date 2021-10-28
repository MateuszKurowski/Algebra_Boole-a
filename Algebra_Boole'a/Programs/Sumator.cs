using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Algebra_Boole_a.Programs
{
    class Sumator
    {
        public static void MainMenu()
        {
            Program.DisplayMenuTitle(1);

            WindowWidth = 80;
            SetCursorPosition((70 / 2), 12);
            WriteLine("Menu");
            SetCursorPosition((30 / 2), 14);
            WriteLine("1. Ręczny test.");
            SetCursorPosition((30 / 2), 15);
            WriteLine("2. Wszystkie możliwości.");
            SetCursorPosition((30 / 2), 16);
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

        public static void ManualTest()
        {
            Program.DisplayMenuTitle(1);
            WriteLine();

            Write("Podaj pierwszą cyfrę: ");
            while(true)
            {
                string firstBinary = ReadLine();
                if(firstBinary.Length == 4)
                {
                    break;
                }

                Clear();
                Program.DisplayMenuTitle(1);
                WriteLine();

                ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Wprowadzono błędne dane!");
                ForegroundColor = ConsoleColor.White;
                Write("Podaj pierwszą cyfrę (");
                ForegroundColor = ConsoleColor.DarkRed;
                Write("binarną, czterobitową");
                ForegroundColor = ConsoleColor.White;
                Write("): ");
            }

            Clear();
            Program.DisplayMenuTitle(1);
            WriteLine();

            //WriteLine($"")

            Write("Podaj pierwszą drugą: ");
            while (true)
            {

            }


                WriteLine();
            WriteLine("Koniec kurwa");
            ReadKey();
        }


        private static void AllPossibilities()
        {
            int parity = 0;
            int trials = 0;
            List<string> binary = Addons.Constants.BinaryInput();

            Program.DisplayMenuTitle(1);
            WriteLine();

            foreach (string variable in binary)
            {
                int baseOfSum = Convert.ToInt32(variable, 2);
                for (int i = 0; i < binary.Count; i++)
                {
                    if (parity % 2 == 0)
                        ForegroundColor = ConsoleColor.DarkGreen;
                    else ForegroundColor = ConsoleColor.DarkCyan;
                    Write(variable);
                    ForegroundColor = ConsoleColor.White;
                    Write(" + " + binary[i] + " = ");
                    int targetOfSum = Convert.ToInt32(binary[i], 2);
                    string result = Convert.ToString(baseOfSum + targetOfSum, 2).PadLeft(4, '0');
                    if (result.Length > 4)
                    {
                        result = result.Remove(0, result.Length - 4);
                        Write(result);
                        ForegroundColor = ConsoleColor.DarkRed;
                        WriteLine(" [Overflow]");
                        ForegroundColor = ConsoleColor.White;
                    }
                    else WriteLine(result);

                    trials++;
                }
                parity++;
            }
            WriteLine("-----------------------------");

            if (trials == 1)
                WriteLine($"Wykonano: {trials} raz!");
            else WriteLine($"Wykonano: {trials} razy!");

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
