using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchaelogyGame1
{
    public class TreasureCard : Card
    {
        //rarity of the card
        protected int _rarity;
        //trading value of the treasure card
        protected int _tradingValue;
        //values for selling
        protected List<int> _sellingValues;

         /// <summary>
         /// Initialise a treasure card
         /// </summary>
         /// <param name="name">name of card</param>
        public TreasureCard(string name) : base(name)
        {

        }
        /// <summary>
        /// Get the list of selling valiues
        /// </summary>
        public List<int> SellingValues
        {
            get { return _sellingValues; }
        }
        /// <summary>
        /// get a list of trading values
        /// </summary>
        public int TradingValue
        {
            get { return _tradingValue; }
        }


        /// <summary>
        /// Overriding th tostring method to return the cards
        /// name, trading value, rarity, selling value
        /// </summary>
        /// <returns>The name, trading value, rarity, selling value</returns>
        public override string ToString()
        {
            string text = Name.PadRight(20) + "Trading Value: " +  _tradingValue.ToString().PadRight(2) + "Rarity: " + _rarity.ToString().PadRight(3) + "Selling Value: [";
            //looping through the listed selling values of each card
            for(int i = 0; i < _sellingValues.Count; i ++)
            {
                //Add a letter N for the number of cards 
                text += "N" + (i + 1) + "=" + _sellingValues[i] ;
                //if the list isn't the last item add a colon
                if(i < _sellingValues.Count - 1)
                {
                    text += " ,";
                }

            }
            //return the text 
            return text + "]";



        }

    }
}
