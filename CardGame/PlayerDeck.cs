using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchaelogyGame1
{
    public class PlayerDeck : Deck
    {
        //playerdeck list
        protected List<Card> _playersDeck;



        /// <summary>
        /// Initialising a player deck of cards
        /// </summary>
        public PlayerDeck()
        {
            //_cardsList = new List<Card>();
            _playersDeck = new List<Card>();
        }

        /// <summary>
        /// Get and set the playersdeck list
        /// </summary>
        public  List<Card> PlayersDeck
        {
            get { return _playersDeck; }
            set { _playersDeck = value; }
        }

        /// <summary>
        /// overrides the add to add to the list
        /// </summary>
        /// <param name="card"></param>
        public override void Add(Card card)
        {
            _playersDeck.Add(card);
        }

        //}

        /// <summary>
        /// returns a card from the deck and removes it from the main deck
        /// </summary>
        /// <returns>Card from deck</returns>
        public override Card getCard()
        {
            Card card = null;
            if (_playersDeck.Count > 0)
            {
                card = _playersDeck[0];
                _playersDeck.RemoveAt(0);
            }
            return card;

        }
        /// <summary>
        /// removes a card given from list
        /// </summary>
        /// <param name="name"></param>
        public void RemoveCard(String name)
        {
            bool nameFound = false;
            if (nameFound == false)
            {
                for(int i = 0; i < _playersDeck.Count; i++)
                {
                    if (_playersDeck[i].Name == name)
                    {
                        _playersDeck.Remove(_playersDeck[i]);
                        nameFound = true;
                    }
                }
            }


        }

        /// <summary>
        /// Diaplay the items in the deck to the listbox
        /// <param name="listBoxDisplay">The listbox for displaying the information</param>
        public void DisplayPlayerDeck(ListBox listBoxDisplay)
        {
            int count = 1;
            //clear the listbox
            listBoxDisplay.Items.Clear();
            //foreach card in the card list
            for(int i = 0; i < _playersDeck.Count; i++)
            {
                //display in listbox
                listBoxDisplay.Items.Add(_playersDeck[i]);

            }

        }



    }
}
