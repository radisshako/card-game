using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchaelogyGame1
{
    public abstract class Deck
    {
        //list for cards in a deck
        public List<Card> _cardsList;

        /// <summary>
        /// Initialising a deck of cards
        /// </summary>
        public Deck()
        {
            _cardsList = new List<Card>();
        }

        /// <summary>
        /// Gets the cards in the list
        /// </summary>
        public List<Card> CardsList
        {
            get { return _cardsList; }
            set { _cardsList = value; }
        }

        public abstract void Add(Card card);


        /// <summary>
        /// Diaplay the items in the deck to the listbox
        /// <param name="listBoxDisplay">The listbox for displaying the information</param>
        public virtual void DisplayDeck(ListBox listBoxDisplay)
        {
            int count = 1;
            //clear the listbox
            listBoxDisplay.Items.Clear();
            //foreach circle in the circle list
            foreach (Card c in CardsList)
            {
                if (count < 5)
                {
                    //add the card information to the listbox
                    listBoxDisplay.Items.Add(c);
                    count++;
                }
            }

        }
        ///// <summary>
        ///// returns a card from the deck and removes it from the main deck
        ///// </summary>
        ///// <returns>Card from deck</returns>
        //public Card getCard(List<Card> cardList)
        //{
        //    Card card = null;
        //    if(cardList.Count > 0)
        //    {
        //        card = _cardsList[0];
        //        cardList.RemoveAt(0);
        //    }
        //    return card;

        //}

        /// <summary>
        /// returns a card from the deck and removes it from the main deck
        /// </summary>
        /// <returns>Card from deck</returns>
        public abstract Card getCard();

        //public void RemoveCard(String name)
        //{
        //    bool nameFound = false;
        //    foreach (Card c in _cardsList)
        //    {
        //        if (c.Name == name && nameFound == false)
        //        {
        //            _cardsList.Remove(c);
        //            nameFound = true;
        //        }
        //    }


        //}
        //public List<Card> GetSelectedCards()
        //{
        //    List<Card> selectedCards = new List<Card>();

        //    foreach(Card c in _cardsList)
        //    {

        //    }
        //}

        //public void ClickedItems(ListBox listBoxDisplay)
        //{
        //    foreach (Card c in _cardsList)
        //    {

        //    }
        //}
    }
}
