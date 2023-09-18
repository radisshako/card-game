using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchaelogyGame1
{
    public class OpponentDeck : Deck
    {
        //list of opponents cards
        protected List<Card> _opponentDeck;



        /// <summary>
        /// Initialising a player deck of cards
        /// </summary>
        public OpponentDeck()
        {
            //_cardsList = new List<Card>();
            _opponentDeck = new List<Card>();
        }

        /// <summary>
        /// get and set the opponetns list
        /// </summary>
        public List<Card> OpponentsDeckList
        {
            get { return _opponentDeck; }
            set { _opponentDeck = value; }
        }
        /// <summary>
        /// add to the opponents list
        /// </summary>
        /// <param name="card">card to add</param>
        public override void Add(Card card)
        {
            _opponentDeck.Add(card);
        }

        /// <summary>
        /// returns a card from the deck and removes it from the main deck
        /// </summary>
        /// <returns>Card from deck</returns>
        public override Card getCard()
        {
            Card card = null;
            if (_opponentDeck.Count > 0)
            {
                card = _opponentDeck[0];
                _opponentDeck.RemoveAt(0);
            }
            return card;

        }

        

        /// <summary>
        /// Diaplay the items in the deck to the listbox
        /// <param name="listBoxDisplay">The listbox for displaying the information</param>
        public void DisplayOpponentDeck(ListBox listBoxDisplay)
        {
            int count = 1;
            //clear the listbox
            listBoxDisplay.Items.Clear();
            //foreach card in the card list
            for (int i = 0; i < _opponentDeck.Count; i++)
            {
                //display in listbox
                listBoxDisplay.Items.Add(_opponentDeck[i]);

            }

        }
    }
}
