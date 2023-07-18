using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        abstract class HumanPlayer
         HumanPlayer playerOne { get; 
        {

            //Member Variabes (HAS A)
            public string name;
            public List<string> gestures;
            public string chosenGesture;
            public int score;

            //Constructor
            public void Player(string name)


            {
                this.name = name;
                gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
                chosenGesture = "";
                score = 0;
            }

            //Member Methods (CAN DO)
            //This abstract method must be overridden by the child Player classes
            Player playerOne
        
            public abstract void ChooseGesture();


        }  
    }
}
