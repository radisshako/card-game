using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class Talismans : TreasureCard
    {
        /// <summary>
        /// Initialisees the Talismans card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public Talismans(string name) : base(name)
        {
            _rarity = 8;
            _tradingValue = 3;
            _sellingValues = new List<int>() { 3, 7, 14, 24, 40 };
        }
    }
}
