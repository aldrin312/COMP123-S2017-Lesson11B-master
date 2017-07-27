using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 25, 2017
 * Description: This is the Deck class
 * It inherits from the List generic and uses Card as the base type
 * Version: 0.1 - Created the Deck class
 */

namespace COMP123_S2017_Lesson11B
{
    public class Deck : CardList
    {
		// PRIVATE INSTANCE VARIABLES
		private Random _random;

		//private proterties
		private Random Random
		{
			get
			{
				return this._random;
			}
		}

        // PUBLIC PROPERTIES

        // CONSTRUCTOR
        

        // PRIVATE METHODS

        /// <summary>
        /// This is the Initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        protected override void _initialize()
        {
			//initialize the pseudo random number generator

			this._random = new Random();

			//this builds the deck
            for (int suit = (int)Suit.Clubs; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = (int)Face.Ace; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method.
        /// </summary>
        /// <returns>
        /// This method returns the current cards in the deck
        /// </returns>
        public override string ToString()
        {
			
            string outputString = "";
			outputString += "Deck Contains " + this.Count + "\n";
			outputString+= "=========================================== \n";
			int i =1;
            foreach (Card card in this)
            {

                outputString += i+ " The " + card.Face + " of " + card.Suit + "\n";
				i++;
            }

            return outputString;
        }

		/// <summary>
		/// uses the fisher-yates like algorithm
		/// </summary>
		public void Shuffle()
		{
			int firstCard;
			int secondCard;
			Card tempCard;
			for (int card = 0; card < this.Count; card++)
			{
				firstCard = this.Random.Next(0, this.Count);
				secondCard = this.Random.Next(0, this.Count);
				tempCard = (Card)this[secondCard].Clone();
				Card.Overwrite(this[secondCard], this[firstCard]);
				Card.Overwrite(this[firstCard], tempCard);

				
			
			}
		}
		/// <summary>
		/// this method returns the top card of the deck
		/// </summary>
		/// <returns></returns>
		public Card Deal1()
		{
			Card topCard = this[0];
			this.RemoveAt(0); // remove the top card from the deck

			return topCard;
		}
    }
}