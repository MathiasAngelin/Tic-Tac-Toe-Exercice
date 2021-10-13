using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Exercice
{
    class Players
    {
        public string Name { get; set; }
        public int NumberOfWins { get; private set; }
        public Players(string name)
        {
            Name = name;

        }

        public void PlayerWon()
        {
            NumberOfWins++;
        }

        public void DisplayNameandWin()
        {
            Console.WriteLine($"{Name} - num of wins: {NumberOfWins}");
        }

    }
}
