using System;

namespace csharpPracticeFun
{
    class Driver
    {
        static void Main(string[] args)
        {
            string playAgain = "y";
            while (playAgain == "y"){

                Console.WriteLine("Welcome to Tic Tac Toe!!");
                string[,] board = new string[3, 3];
                for (int x = 0; x < 3; x++)
                {
                    for (int iin = 0; iin < 3; iin++)
                    {
                        board[x, iin] = "_";
                        Console.Write(board[x, iin] + " ");
                    }
                    Console.WriteLine();
                }
            ;
                string player = "";
                bool winner = false;
                int i = 1;
                //for (int i = 1; i <= 9; i++)
                while (i < 10 || winner == false)
                {
                    if (i % 2 == 0)
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
                    support.winnerCheck(board);
                    i++;

                    //for (int x = 0; x < 3; x++)
                    //{
                    //    for (int iin = 0; iin < 3; iin++)
                    //    {

                    //        Console.Write(board[x, iin] + " ");
                    //    }
                    //    Console.WriteLine();
                    //}
                }

                if (i == 9 && winner == false)
                {
                    Console.WriteLine("It's a DRAW!");
                }
                //else
                //{
                //    Console.WriteLine(player + "WINS!!!");
                //}

                Console.Write("Play again? Y/N:  ");
                playAgain = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Thanks for playing!!");
        }
        
    }
}
