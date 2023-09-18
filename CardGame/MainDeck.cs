using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchaelogyGame1
{
    public class MainDeck : Deck
    {
        protected List<Card> _mainDeck;



        /// <summary>
        /// Initialising a player deck of cards
        /// </summary>
        public MainDeck()
        {
            //_cardsList = new List<Card>();
            _mainDeck = new List<Card>();
        }

        public List<Card> MainDeckList
        {
            get { return _mainDeck; }
            set { _mainDeck = value; }  
        }

        /// <summary>
        /// returns a card from the deck and removes it from the main deck
        /// </summary>
        /// <returns>Card from deck</returns>
        public override Card getCard()
        {
            Card card = null;
            if (_mainDeck.Count > 0)
            {
                card = _mainDeck[0];
                _mainDeck.RemoveAt(0);
            }
            return card;

        }
        //public void AddOpponentCards()
        //{
        //    //Add 4 cards for opponent card deck
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Card c = getCard();
        //        _opponentDeck.Add(c);

        //    }
        //}

        /// <summary>
        /// Diaplay the items in the deck to the listbox
        /// <param name="listBoxDisplay">The listbox for displaying the information</param>
        public override void DisplayDeck(ListBox listBoxDisplay)
        {
            int count = 1;
            //clear the listbox
            //listBoxDisplay.Items.Clear();
            //foreach card in the card list
            for (int i = 0; i < _mainDeck.Count; i++)
            {
                //display in listbox
                listBoxDisplay.Items.Add(_mainDeck[i]);

            }

        }

        public override void Add(Card card)
        {
            _mainDeck.Add(card);
        }
    }
}
