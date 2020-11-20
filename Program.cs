using System;

namespace SmallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Welcome!");

            Console.Clear();
            string[] level_a = 
            {
            "#####################################################################   #",
            "#   #               #                  ##       #                   # ^ #",
            "#   #   #########   #   #####   #########   #####   #####   #####   #   #",
            "#               #       #   # -         #           # - #   #       #   #",
            "#  ######   #   #########   #########   #####   #   #   #   #########   #",
            "#       #   #      -        #           #   #   #   #   #           #   #",
            "#   #   #############   #   #   #########  +#####   #   #########   #   #",
            "#   #               #   #   #       #           #           #       #   #",
            "#   #############   #####   #####       #####   #### ####   #   #####   #",
            "#           #-      #   #       #   # +     #           #               #",
            "#########################################################################",
            };
            
            foreach(string row in level_a)
            {
                Console.WriteLine(row);
            }
            int positionRow = 2;
            int positionCol = 1;
            int scores = 0;
            while(true)
            {
                
                Console.SetCursorPosition(0, level_a.Length + 1);
                Console.Write("Score: " + scores);
                Console.SetCursorPosition(positionCol, positionRow);
                Console.Write("@");
                Console.SetCursorPosition(0, level_a.Length-1);
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

                if (targetCol > 0  && targetCol < level_a[0].Length - 1 && level_a[positionRow][targetCol] != '#')
                {
                    positionCol = targetCol;
                }
                if (targetRow > 0 && targetRow < level_a.Length - 1 && level_a[targetRow][positionCol] != '#')
                {
                    positionRow = targetRow;
                }
                if (level_a[targetRow][positionCol] == '-' && level_a[positionRow][targetCol] == '-')
                {
                    scores ++;
                    // Console.SetCursorPosition(positionCol, positionRow);
                    // Console.Write("");
                }

                if (level_a[targetRow][positionCol] == '^' & level_a[positionRow][targetCol] == '^'){
                    Console.SetCursorPosition(0, level_a.Length + 2);
                    Console.WriteLine ("FINISH !!");
                }

            }

            Console.WriteLine ("  ");
            Console.WriteLine ("Press any key to quit");
            Console.ReadKey(true);
        }
    }
}
