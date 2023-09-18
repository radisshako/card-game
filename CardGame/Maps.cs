using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class Maps : TreasureCard
    {
        /// <summary>
        /// Initialisees the Maps card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public Maps(string name) : base(name)
        {
            _rarity = 6;
            _tradingValue = 3;
            _sellingValues = new List<int>() { 3 };
        }
    }
}
