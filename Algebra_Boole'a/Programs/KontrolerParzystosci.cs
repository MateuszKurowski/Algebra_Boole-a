using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Algebra_Boole_a.Programs
{
    class KontrolerParzystosci
    {
        public static void MainMenu()
        {
            Program.DisplayMenuTitle(3);

            WindowWidth = 80;
            SetCursorPosition((70 / 2), 12);
            WriteLine("Menu");
            WriteLine();
            WriteLine();
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
                    //
                    break;
                case ConsoleKey.D2:
                    //
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.Escape:
                    Program.Main();
                    break;
            }
            MainMenu();
        }
    }
}