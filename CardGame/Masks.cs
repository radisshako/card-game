using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class Masks : TreasureCard
    {
        /// <summary>
        /// Initialisees the Masks card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public Masks(string name) : base(name)
        {
            _rarity = 4;
            _tradingValue = 4;
            _sellingValues = new List<int>() { 4, 12, 26, 50 };
        }
    }
}
