using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public abstract class Card
    {
        //the name of the card
        protected string _name;

        /// <summary>
        /// Gets the name of the card
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Initialises a card
        /// </summary>
        /// <param name="name">The name of the card</param>
        public Card(string name)
        {
            _name = name;
        }

        /// <summary>
        /// overriding the built in to string method
        /// </summary>
        /// <returns>The card name padded</returns>
        public override string ToString()
        {
            return Name.PadRight(23);
        }
    }
}
