using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Aldrin Fernandez
 * Date: July 25, 2017
 * Description: This is a demo for Lesson 11
 * Version: 0.2 - Implemented / tested the Deck class
 */

namespace COMP123_S2017_Lesson11B
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
			Hand hand = new Hand();

            Console.WriteLine(deck.ToString());
			Console.WriteLine();
			Console.WriteLine("Shuffled");
			deck.Shuffle();
			Console.WriteLine(deck.ToString());

			hand.Add(deck.Deal1());
			Console.WriteLine(hand.ToString());
			hand.Add(deck.Deal1());
			Console.WriteLine(hand.ToString());
			hand.Add(deck.Deal1());
			Console.WriteLine(hand.ToString());

			Console.WriteLine(deck.ToString());

			hand = deck.Deal5();
			Console.WriteLine(hand.ToString());

		}
	}
}
