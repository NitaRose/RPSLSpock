using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
        
           
        
        //Constructor
        public Game()
        {             
          
           

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper \nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
            

        }

        public int ChooseNumberOfHumanPlayers(Player HumanPlayer) 
        {
            Console.WriteLine("How many Brave Souls will play today?:");
            Console.ReadKey();
            if(playerOne != null)
            {
                Console.WriteLine("What is your name Player?");
               playerOne.name = Console.ReadLine();
               
                playerOne = this.name(HumanPlayer);
                return 1;
            }if(playerTwo != null && playerOne != null)
            {
                char
            Console.ReadLine();
            }
            return 2;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
