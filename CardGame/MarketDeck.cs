using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchaelogyGame1
{
    public class MarketDeck : Deck
    {
        //List of the market cards
        protected List<Card> _marketDeck;



        /// <summary>
        /// Initialising a market deck of cards
        /// </summary>
        public MarketDeck()
        {
            //_cardsList = new List<Card>();
            _marketDeck = new List<Card>();
        }

        /// <summary>
        /// get and set the market deck
        /// </summary>
        public List<Card> MarketDeckList
        {
            get { return _marketDeck; }
            set { _marketDeck = value; }
        }

        /// <summary>
        /// override the add to add to market list
        /// </summary>
        /// <param name="card"></param>
        public override void Add(Card card)
        {
            _marketDeck.Add(card);
        }

        

        /// <summary>
        /// returns a card from the deck and removes it from the main deck
        /// </summary>
        /// <returns>Card from deck</returns>
        public override Card getCard()
        {
            Card card = null;
            if (_marketDeck.Count > 0)
            {
                card = _marketDeck[0];
                _marketDeck.RemoveAt(0);
            }
            return card;

        }

        /// <summary>
        /// Diaplay the items in the deck to the listbox
        /// <param name="listBoxDisplay">The listbox for displaying the information</param>
        public void DisplayMarketDeck(ListBox listBoxDisplay)
        {
            int count = 1;
            //clear the listbox
            listBoxDisplay.Items.Clear();
            //foreach card in the card list
            for (int i = 0; i < _marketDeck.Count; i++)
            {
                //display in listbox
                listBoxDisplay.Items.Add(_marketDeck[i]);

            }

        }


    }
}
