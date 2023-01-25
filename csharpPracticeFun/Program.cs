using System;

namespace csharpPracticeFun
{
    class Driver
    {
        static void Main(string[] args)
        {
            // begin a while loop so that players can play several times
            string playAgain = "y";
            while (playAgain == "y"){
                
                // welcome users to the game and create the board array with just "_"
                Console.WriteLine("Welcome to Tic Tac Toe!!");
                string[,] board = new string[3, 3];

                
                for (int x = 0; x < 3; x++)
                {
                    for (int iin = 0; iin < 3; iin++)
                    {
                        board[x, iin] = "_";
                    }
                }

                // call the printBoard method to display the empty tictactoe board
                Support supp1 = new Support();
                supp1.printBoard(board);

                // instantiate all variables globally
                string player = "";
                bool winner = false;
                int i = 1;

                // create a while loop that keeps the user playing UNLESS a player wins or 9 turns are used
                while (i < 10 && winner == false)
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

                    // update the board with the player's selection
                    board[col - 1, row - 1] = player;

                    // print the board and check if there was a winner
                    //Support support = new Support();
                    supp1.printBoard(board);
                    winner = supp1.winnerCheck(board);

                    i++;
                }
                
                // if no winner, but 9 turns have been used, print that it was a draw
                if (winner == false)
                {
                    Console.WriteLine("It's a DRAW!\n");
                }

                // ask if the user wants to play again, if not, break the larger while loop
                Console.Write("Play again? Y/N:  ");
                playAgain = Console.ReadLine().ToLower();
            }

            // thank the user for playing!
            Console.WriteLine("\n\nThanks for playing!!");
        }
        
    }
}
