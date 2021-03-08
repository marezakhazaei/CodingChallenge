using CodingChallenge.CardGame;
using System;

namespace TestCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PackOfCardsCreator();
            var cards = factory.Create();
            cards.Shuffle();
            var t = cards.TakeCardFromTopOfPack();
            cards.Shuffle();
            Console.WriteLine("Hello World!");
        }
    }
}
