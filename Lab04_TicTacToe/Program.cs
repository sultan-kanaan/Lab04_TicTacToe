using System;
using Lab04_TicTacToe.Classes;


namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic-tac-toe Game");
            StartGame();

        }

        static void StartGame()
        {
            // TODO: Instantiate your players DONE
            Console.Write("Please enter name for Player 1: ");
            string playerOneName = Console.ReadLine();
            Console.Write("Please enter name for Player 2: ");
            string playerTwoName = Console.ReadLine();

            Player p1 = new Player
            {
                Name = playerOneName,
                Marker = "X",
                IsTurn = true
            };

            Player p2 = new Player
            {
                Name = playerTwoName,
                Marker = "O",
                IsTurn = false
            };

            // Create the Game 
            Game newGame = new Game(p1, p2);

            // Play the Game 
            Player winner = newGame.Play();

            // Output the winner 
            if (winner == null)
                Console.WriteLine("It is draw!");
            else
                Console.WriteLine($"{winner.Name} is the winner.");
        }


    }
}
