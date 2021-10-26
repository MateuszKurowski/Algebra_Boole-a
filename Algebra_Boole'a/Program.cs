using System;
using System.Text;
using static System.Console;

namespace Algebra_Boole_a
{
    /// <summary>
    /// Główna klasa programu
    /// </summary>
    class Program
    {
        /// <summary>
        /// Główne menu programu
        /// </summary>
        public static void Main()
        {
            Programs.Sumator.AllPossibilities();

            DisplayMenuTitle(0);

            WindowWidth = 80;
            SetCursorPosition((70 / 2), 12);
            WriteLine("Menu");
            SetCursorPosition((30 / 2), 14);
            WriteLine("1. Sumator.");
            SetCursorPosition((30 / 2), 15);
            WriteLine("2. Komparator.");
            SetCursorPosition((30 / 2), 16);
            WriteLine("3. Kontroler bitów parzystości.");
            SetCursorPosition((30 / 2), 17);
            WriteLine("4. Autor.");
            SetCursorPosition((30 / 2), 18);
            WriteLine("5. Wyjdź.");

            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey keyPressed = keyInfo.Key;

            switch(keyPressed)
            {
                case ConsoleKey.D1:
                    Programs.Sumator.MainMenu();
                    break;
                case ConsoleKey.D2:
                    Programs.Komparator.MainMenu();
                    break;
                case ConsoleKey.D3:
                    Programs.KontrolerParzystosci.MainMenu();
                    break;
                case ConsoleKey.D4:
                    Programs.Autor.Menu();
                    break;
                case ConsoleKey.D5:
                    Environment.Exit(-1);
                    break;
            }
            Main();
        }

        /// <summary>
        /// Pokazuje tytułowy obrazek
        /// </summary>
        /// <param name="image">numer obrazka</param>
        public static void DisplayMenuTitle(int image)
        {
            OutputEncoding = Encoding.UTF8;
            Clear();
            ForegroundColor = ConsoleColor.White;
            CursorVisible = false;
            WriteLine("---------------------------------------------------------------------------");
            switch(image)
            {
                case 0:
                    WriteLine(@"
           _            _                 ____              _      _       
     /\   | |          | |               |  _ \            | |    ( )      
    /  \  | | __ _  ___| |__  _ __ __ _  | |_) | ___   ___ | | ___|/  __ _ 
   / /\ \ | |/ _` |/ _ \ '_ \| '__/ _` | |  _ < / _ \ / _ \| |/ _ \  / _` |
  / ____ \| | (_| |  __/ |_) | | | (_| | | |_) | (_) | (_) | |  __/ | (_| |
 /_/    \_\_|\__, |\___|_.__/|_|  \__,_| |____/ \___/ \___/|_|\___|  \__,_|
              __/ |                                                        
             |___/                                                         
");
                    break;
                case 1:
                    WriteLine(@"
   _____                       _             
  / ____|                     | |            
 | (___  _   _ _ __ ___   __ _| |_ ___  _ __ 
  \___ \| | | | '_ ` _ \ / _` | __/ _ \| '__|
  ____) | |_| | | | | | | (_| | || (_) | |   
 |_____/ \__,_|_| |_| |_|\__,_|\__\___/|_|   


");
                    break;
                case 2:
                    WriteLine(@"
  _  __                                     _             
 | |/ /                                    | |            
 | ' / ___  _ __ ___  _ __   __ _ _ __ __ _| |_ ___  _ __ 
 |  < / _ \| '_ ` _ \| '_ \ / _` | '__/ _` | __/ _ \| '__|
 | . \ (_) | | | | | | |_) | (_| | | | (_| | || (_) | |   
 |_|\_\___/|_| |_| |_| .__/ \__,_|_|  \__,_|\__\___/|_|   
                     | |                                  
                     |_|    
");
                    break;
                case 3:
                    WriteLine(@"
  _  __           _             _           
 | |/ /          | |           | |          
 | ' / ___  _ __ | |_ _ __ ___ | | ___ _ __ 
 |  < / _ \| '_ \| __| '__/ _ \| |/ _ \ '__|
 | . \ (_) | | | | |_| | | (_) | |  __/ |   
 |_|\_\___/|_| |_|\__|_|  \___/|_|\___|_|   

                                                      
");
                    break;
            }
            WriteLine("---------------------------------------------------------------------------");
        }
    }
}
