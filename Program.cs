using System;

namespace SmallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Welcome!");
            Console.WriteLine ("Write your name:");
            string username = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(username))
                {
                    username = "Stranger";
                    Console.WriteLine ("So you are" + username);
                }
                Console.Clear();
                Console.WriteLine ("Hello " + username );
                Console.WriteLine ("  ");

                string[] level = 
                {
                "##########",
                "#  #######",
                "#   ######",
                "##   #####",
                "##  ######",
                "##     ###",
                "##     ###",
                "## #######",
                "## #######",
                "##       #"
                };
                
            foreach(string row in level)
            {
                Console.WriteLine(row);
            }
            int positionRow = 3;
            int positionCol = 2;
            while(true)
            {
                Console.SetCursorPosition(positionCol, positionRow);
                Console.Write("@");
                Console.SetCursorPosition(0, level.Length + 1);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Console.SetCursorPosition(positionCol, positionRow);
                Console.Write(" ");      
                if(keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    positionCol--;   
                }
                else if(keyInfo.Key == ConsoleKey.RightArrow)
                {
                    positionCol++;  
                }
                else if(keyInfo.Key == ConsoleKey.UpArrow)
                {
                    positionRow--;     
                }
                else if(keyInfo.Key == ConsoleKey.DownArrow)
                {
                    positionRow++;     
                }
            }
            Console.WriteLine ("  ");
            Console.WriteLine ("Press any key to quit");
            Console.ReadKey(true);
        }
    }
}
