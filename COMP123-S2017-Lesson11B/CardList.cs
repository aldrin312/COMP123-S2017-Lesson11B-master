using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Aldrin Fernandez
 * Date: July 25, 2017
 * Description: This is the abstract card list super class
 * Version: 0.3 - refactor to exxtend the abstract class
 */

namespace COMP123_S2017_Lesson11B
{
	public abstract class CardList : List<Card>
	{
		//private intance variables

		//public properties

		//constructors

		public CardList()
		{
			this._initialize();
		}

		// PRIVATE METHODS

		protected abstract void _initialize();

		//private methods

		//public methods

	}
}