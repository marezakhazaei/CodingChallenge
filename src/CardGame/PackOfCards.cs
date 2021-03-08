using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        public PackOfCards()
        {
            var values = Enum.GetValues(typeof(Value)).Cast<Value>();
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    pack.Add(new Card(value, suit));
                }
            }
        }

        private readonly IList<ICard> pack = new List<ICard>();
        private readonly IList<ICard> removedPack = new List<ICard>();
        public int Count => pack.Count;
        public IEnumerator<ICard> GetEnumerator()
        {
            return pack.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Shuffle()
        {
            if (Count != 52)
            {
                if (removedPack.Count != 0)
                    for (int i = removedPack.Count - 1; i >= 0; i--)
                    {
                        pack.Add(removedPack[i]);
                        removedPack.RemoveAt(i);
                    }
            }
            Random num = new Random();
            for (int i = 0; i < pack.Count - 1; i++)
            {
                int ran = num.Next(pack.Count);
                ICard temp = pack.ElementAt(ran);
                pack.RemoveAt(ran);
                pack.Insert(i, temp);
            }
        }
        public ICard TakeCardFromTopOfPack()
        {
            int topCard = 0;
            ICard cardRemoved = pack.ElementAt(topCard);
            pack.RemoveAt(topCard);
            removedPack.Add(cardRemoved);
            return cardRemoved;
        }
    }
}
