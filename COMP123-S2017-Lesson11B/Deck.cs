﻿using System;
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
    public class Deck : List<Card>
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
        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public Deck()
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This is the Initialize method it sets values for private variables
        /// and public properties as well as other class objects.
        /// </summary>
        private void _initialize()
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

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

		public void Shuffle()
		{
			int firstCard;
			int secondCard;
			Card tempCard;
			for (int card = 0; card < this.Count; card++)
			{
				firstCard = this.Random.Next(0, 52);
				secondCard = this.Random.Next(0, 52);

				tempCard = (Card)this[secondCard].Clone();
				this[secondCard].Face = this[firstCard].Face;
				this[secondCard].Suit = this[firstCard].Suit;
				this[firstCard].Face = tempCard.Face;
				this[firstCard].Suit = tempCard.Suit;
			}
		}
    }
}