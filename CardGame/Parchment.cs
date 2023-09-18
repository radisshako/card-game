using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class Parchment : TreasureCard
    {
        /// <summary>
        /// Initialisees the Parchment card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public Parchment(string name) : base(name)
        {
            _rarity = 16;
            _tradingValue = 1;
            _sellingValues = new List<int>() { 1, 2, 3, 10};
        }

    }
}
