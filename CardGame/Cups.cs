using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class Cups : TreasureCard
    {
        /// <summary>
        /// Initialisees the Cups card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public Cups(string name) : base(name)
        {
            _rarity = 6;
            _tradingValue = 2;
            _sellingValues = new List<int>() { 2, 15};
        }
    }
}
