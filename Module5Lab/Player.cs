using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace holds one or more classes
namespace Module5Lab
{
    internal class Player
    {
        //Variables for the class attributes
        private string name;
        private int score;
        private int livesLeft;

        // Three constructors
        // First constructor creates a Player object
        // without setting the values of the attributes
        public Player()
        {

        } //end constructor

        // Second constructor
        public Player(string name)
        {
            // Set the value of the attribute on the Player object
            //to the name value that was passed when the method
            // was called
            this.name = name;
        } // end constructor

        // Third constructor 
        public Player(string name, int startingLives)
        {
            // Set the name attribute and the livesLeft attribute
            //to the values that were passed to the constructor
            // method
            this.name = name;
            livesLeft = startingLives;
        } //end constructor

        // Methods - these are tasks or actions
        // that our object can perform or that can
        // change the state of the object

        // This method returns the score
        public int GetScore()
        {
            return score;
        } //end method

        //This method increments the points the player has
        public void AddPoints(int totalPoints)
        {
            // Increment the score
            score += totalPoints;
            // score = score + totalPoints;
        } //end method

        //This method kills off the player
        public void Kill()
        {
            //We make sure they can't get negative lives
            if (livesLeft > 0)
            {
                livesLeft--;
                // livesLeft = livesLeft - 1;
            } //end if
        } //end method

        public int GetLivesLeft()
        {
            return livesLeft;
        } //end method 

    } //end class
} //end namespace