using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Exercice
{
    class Boardmaker
    {
        public string[] slots = new string[10] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };




        public Boardmaker()
        {
        }

        public void DrawBoard()
        {

            Console.WriteLine($"\n {slots[1]} | {slots[2]} | {slots[3]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {slots[4]} | {slots[5]} | {slots[6]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {slots[7]} | {slots[8]} | {slots[9]} \n");

        }

        public void PlayerInput(string symbol)
        {

            bool inputOK = false;
            int numberPicked;
            Console.WriteLine($"Enter the slot you want from top left to bottom right");
            while (inputOK == false)
            {
                numberPicked = int.Parse(Console.ReadLine());

                for (int i = 0; i < slots.Length; i++)
                {
                    if (numberPicked == i)
                    {
                        if (slots[i] == " ")
                        {
                            slots[i] = symbol;
                            inputOK = true;
                        }
                        else
                        {
                            Console.WriteLine("That slot is occupied, take another");
                        }
                    }
                }
            }
        }

        public bool CheckWin()
        {
            if (((slots[1] == slots[2] && slots[2] == slots[3]) && (slots[2] == "X" || slots[2] == "O")) ||
                ((slots[4] == slots[5] && slots[5] == slots[6]) && (slots[5] == "X" || slots[5] == "O")) ||
                ((slots[7] == slots[8] && slots[8] == slots[9]) && (slots[8] == "X" || slots[8] == "O")) ||
                ((slots[1] == slots[5] && slots[5] == slots[9]) && (slots[5] == "X" || slots[5] == "O")) ||
                ((slots[3] == slots[5] && slots[5] == slots[7]) && (slots[5] == "X" || slots[5] == "O")) ||
                ((slots[1] == slots[4] && slots[4] == slots[7]) && (slots[4] == "X" || slots[4] == "O")) ||
                ((slots[2] == slots[5] && slots[5] == slots[8]) && (slots[5] == "X" || slots[5] == "O") ||
               ((slots[3] == slots[5] && slots[5] == slots[9]) && (slots[5] == "X" || slots[5] == "O"))))
            {
                Console.WriteLine(" You Won! - Press enter to restart");
                Console.ReadLine();
                return true;
                

            }
            else 
                return false;
           






        }
    }
}
