using System;

namespace Tic_Tac_Toe_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {

            Boardmaker myBoard = new Boardmaker();
            Console.WriteLine("Enter player ones name");
            string player1 = Console.ReadLine();
            Console.WriteLine("Enter player twos name");
            string player2 = Console.ReadLine();

            Players playerOne = new Players(player1);
            Players playerTwo = new Players(player2);
            Console.Clear();
            while (true)
            {
                Console.Clear();
                playerOne.DisplayNameandWin();
                playerTwo.DisplayNameandWin();
                Console.WriteLine($"{playerOne.Name} Is X, {playerTwo.Name} is O");
                myBoard.DrawBoard();
                Console.WriteLine($"It's {playerOne.Name}'s turn");
                myBoard.PlayerInput("X");
               if (myBoard.CheckWin())
                {
                    playerOne.PlayerWon();
                    myBoard = new Boardmaker();
                }

                Console.Clear();
                playerOne.DisplayNameandWin();
                playerTwo.DisplayNameandWin();
                Console.WriteLine($"{playerOne.Name} Is X, {playerTwo.Name} is O");
                myBoard.DrawBoard();
                Console.WriteLine($"It's {playerTwo.Name}'s turn");
                myBoard.PlayerInput("O");
                if (myBoard.CheckWin())
                {
                    playerTwo.PlayerWon();
                    myBoard = new Boardmaker();
                }
            }
        }
    }
}
