using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player PlayerOne(string name);
        public Player PlayerTwo(string name);
        
        int playerOneScore;
        int playerTwoScore;
        int mainBrainScore;
        
        //Constructor
        public Game()
        {
            Player player = new Player(playerOne);
            Player players = new Player(playerTwo);
            int playerOneScore = new int();
             

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper \nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
            Console.WriteLine("How many Brave souls will tread this journey today?");
            int numberOfHumanPlayers = int.Parse(Console.ReadLine());

        }

        public int ChooseNumberOfHumanPlayers()
        {       //IF statement 

            
            return 0;
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
