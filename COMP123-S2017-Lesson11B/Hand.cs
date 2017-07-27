using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson11B
{
	public class Hand : CardList
	{

		//private intance variables

		//public properties

		//constructors

		//private method
		protected override void _initialize()
		{
			//STUB
			//this method is empty
		}

		public override string ToString()
		{

			string outputString = "";
			outputString += "Hand Contains " + this.Count + "\n";
			outputString += "=========================================== \n";
			int i = 1;
			foreach (Card card in this)
			{

				outputString += i + " The " + card.Face + " of " + card.Suit + "\n";
				i++;
			}

			return outputString;
		}
	}
}