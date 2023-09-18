using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class Coins : TreasureCard
    {
        /// <summary>
        /// Initialisees the Coins card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public Coins(string name) : base(name)
        {
            _rarity = 14;
            _tradingValue = 2;
            _sellingValues = new List<int>() { 2, 5, 10, 18, 30 };
        }

    }
}
