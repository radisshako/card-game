using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class PotShards : TreasureCard
    {
        /// <summary>
        /// Initialisees the PotShard card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public PotShards(string name): base(name)
        {
            _rarity = 18;
            _tradingValue = 1;
            _sellingValues = new List<int>() {1,2,3,4,5};
        }
    }
}
