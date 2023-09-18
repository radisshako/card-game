using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchaelogyGame1
{
    public class PyramidDeck : Deck
    {
        //fields
        //lists for the 3 chambers
        protected List<Card> _pyramidSmall;
        protected List<Card> _pyramidMedium;
        protected List<Card> _pyramidLarge;

        //random generator for first players turn




        /// <summary>
        /// Initialising a player deck of cards
        /// </summary>
        public PyramidDeck()
        {
            //_cardsList = new List<Card>();
            _pyramidSmall = new List<Card>();
            _pyramidMedium = new List<Card>();
            _pyramidLarge = new List<Card>();
        }
        /// <summary>
        /// get and set the small chamber
        /// </summary>
        public List<Card> PyramidSmall
        {
            get { return _pyramidSmall; }
            set { _pyramidSmall = value; }
        }
        /// <summary>
        /// get and set the medium chamber
        /// </summary>
        public List<Card> PyramidMedium
        {
            get { return _pyramidMedium; }
            set { _pyramidMedium = value; }
        }
        /// <summary>
        /// get and set the large chamber
        /// </summary>
        public List<Card> PyramidLarge
        {
            get { return _pyramidLarge; }
            set { _pyramidLarge = value; }
        }
        /// <summary>
        /// add a card to the small list
        /// </summary>
        /// <param name="card">card to add</param>
        public void AddSmall(Card card)
        {
            _pyramidSmall.Add(card);
        }
        /// <summary>
        /// add a card to the medium list
        /// </summary>
        /// <param name="card">card to add</param>
        public void AddMedium(Card card)
        {
            _pyramidMedium.Add(card);
        }
        /// <summary>
        /// add a card to the large list
        /// </summary>
        /// <param name="card">card to add</param>
        public void AddLarge(Card card)
        {
            _pyramidLarge.Add(card);
        }
        /// <summary>
        /// Override getCard
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override Card getCard()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Override add
        /// </summary>
        /// <param name="card"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Add(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
