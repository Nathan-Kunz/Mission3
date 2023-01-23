using System;
using mission3;

namespace csharpPracticeFun
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!!");
            string[,] board  = new string [3,3];
            for( int i = 0; i<3; i++)
            {
                for (int iin = 0; iin<3; iin++)
                {
                    board[i, iin] = "_";
                    Console.Write(board[i, iin] + " ");
                }
                Console.WriteLine();
            }
            ;
            string player;
            for (int i = 1; i <= 9; i++)
            {
                if(i % 2 ==0)
                {
                     player = "O";
                }
                else
                {
                     player = "X";
                }
                
                Console.WriteLine("Player " + player + " it's your turn");
                Console.WriteLine("What Row do you want?");
                int col = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What Column do you want?");
                int row = Convert.ToInt32(Console.ReadLine());

                board[col - 1, row - 1] = player;
                Support support = new Support();
                support.printBoard(board);
                //for (int x = 0; x < 3; x++)
                //{
                //    for (int iin = 0; iin < 3; iin++)
                //    {

                //        Console.Write(board[x, iin] + " ");
                //    }
                //    Console.WriteLine();
                //}
            }
               
            

            
        }
        
    }
}
