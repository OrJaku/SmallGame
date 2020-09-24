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

                string[] level_a = 
                {
                "#####################################################################   #",
                "#   #               #               #           #                   #   #",
                "#   #   #########   #   #####   #########   #####   #####   #####   #   #",
                "#               #       #   #           #           #   #   #       #   #",
                "# #######   #   #########   #########   #####   #   #   #   #########   #",
                "#       #   #               #           #   #   #   #   #           #   #",
                "#   #   #############   #   #   #########   #####   #   #########   #   #",
                "#   #               #   #   #       #           #           #       #   #",
                "#   #############   #####   #####   #   #####   #########   #   #####   #",
                "#           #       #   #       #   #       #           #   #           #",
                "#########################################################################",

                };
                
            foreach(string row in level_a)
            {
                Console.WriteLine(row);
            }
            int positionRow = 2;
            int positionCol = 2;

            while(true)
            {
                Console.SetCursorPosition(positionCol, positionRow);
                Console.Write("@");
                Console.SetCursorPosition(0, level_a.Length);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                Console.SetCursorPosition(positionCol, positionRow);
                char currentCol =  level_a[positionRow][positionCol];
                Console.Write(currentCol); 

                int targetCol = positionCol; 
                int targetRow = positionRow;

                if(keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    targetCol = positionCol - 1;   
                }
                else if(keyInfo.Key == ConsoleKey.RightArrow)
                {
                    targetCol = positionCol + 1;  
                }
                else if(keyInfo.Key == ConsoleKey.UpArrow)
                {
                    targetRow = positionRow - 1;     
                }
                else if(keyInfo.Key == ConsoleKey.DownArrow)
                {
                    targetRow = positionRow + 1;     
                }
                else{
                    break;
                }
                if (targetCol >= 0 && targetCol < level_a[positionCol].Length && level_a[positionRow][targetCol] != '#')
                {
                    positionCol = targetCol;
                }
                if (targetRow >= 0 && targetRow < level_a.Length && targetCol != currentCol && level_a[targetRow][positionCol] != '#')
                {
                    positionRow = targetRow;
                }
            }

            Console.WriteLine ("  ");
            Console.WriteLine ("Press any key to quit");
            Console.ReadKey(true);
        }
    }
}
