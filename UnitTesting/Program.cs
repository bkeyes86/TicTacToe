using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe 3 in a row!");
            StartGame();
        }

        static void StartGame()
        {
            bool play = true;

            while (play == true)
            { 
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.Write("Player 1 enter your name: ");
            string input1 = Console.ReadLine();
            Console.Write("Player 2 enter your name: ");
            string input2 = Console.ReadLine();
            Player p1 = new Player();
            Player p2 = new Player();
            p1.Name = input1;
            p2.Name = input2;
            p1.Marker = "X";
            p2.Marker = "O";
            Game newGame = new Game(p1, p2);
            Player winner = newGame.Play();
            if (winner.Name != "Draw")
            {
                Console.WriteLine("Winner {0}!!!", winner.Name);

            }
            else
            {
                Console.WriteLine("Draw");

            }

            Console.Write("Play again? Y/N");
            string input = Console.ReadLine();
            if (input == "Y" || input == "y" || input == "yes" || input == "yes")
            {
                play = true;

            }
            else
            {
                break;
            }


            }

        }

    }

}

        
        


    
