using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchaelogyGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Main deck for cards
        MainDeck mainDeck = new MainDeck();
        //Deck for player
        PlayerDeck deck = new PlayerDeck();
        //deck for opponent
        OpponentDeck opponentDeck = new OpponentDeck();
        //deck for marketplace
        MarketDeck marketDeck = new MarketDeck();
        //Deck for pyramid
        PyramidDeck pyramidDeck = new PyramidDeck();

        //Variable for the players selling total
        int totalValue = 0;
        //Variable for the opponents selling total
        int totalValue2 = 0;
        //boolen variable for pyramid chamber used
        bool smallUsed = false;
        bool mediumUsed = false;
        bool largeUsed = false;

        //bool for sanstorm card dug out
        bool sandstormSelected = false;
        //Class scope list for sandstorm deck
        int halfinHand = 0;

        /// <summary>
        /// Create the main deck
        /// </summary>
        private void createDeck()
        {
            //creating 18 Pot Shard cards
            for (int i = 0; i < 18; i++)
            {
                mainDeck.Add(new PotShards("Pot Shards"));
            }
            //creating 16 Parchent scrapers
            for (int i = 0; i < 16; i++)
            {
                mainDeck.Add(new Parchment("Parchment Scraper"));
            }
            //creating 14 coins
            for (int i = 0; i < 14; i++)
            {
                mainDeck.Add(new Coins("Coins"));
            }
            //creating 8 Talismans
            for (int i = 0; i < 8; i++)
            {
                mainDeck.Add(new Talismans("Talismans"));
            }
            //creating 6 broken cups
            for (int i = 0; i < 6; i++)
            {
                mainDeck.Add(new Cups("Broken Cups"));
            }
            //creating 4 pharoahs masks
            for (int i = 0; i < 4; i++)
            {
                mainDeck.Add(new Masks("Pharaohs Masks"));
            }
            //testing code
            foreach (Card c in mainDeck.MainDeckList)
            {
                Console.WriteLine(c);
            }
            //shuffle the deck
            shuffle(72);
            //testing code
            foreach (Card c in mainDeck.MainDeckList)
            {
                Console.WriteLine(c);
            }

        }
        /// <summary>
        /// Shuffle a deck of cards
        /// </summary>
        /// <param name="n">The number of times to shuffle</param>
        private void shuffle(int n)
        {
            int i;
            int j;
            Random rand = new Random();
            for (int k = 0; k < n; k++)
            {
                i = (int)(rand.Next(mainDeck.MainDeckList.Count));
                j = (int)(rand.Next(mainDeck.MainDeckList.Count));
                Card temp = mainDeck.MainDeckList[i];
                mainDeck.MainDeckList[i] = mainDeck.MainDeckList[j];
                mainDeck.MainDeckList[j] = temp;
            }

            ////currentCard = 0;
        }
        /// <summary>
        /// Adds a players cards to their hand
        /// </summary>
        private void AddPlayerCards()
        {
            //Add 4 cards for player card deck
            for (int i = 0; i < 4; i++)
            {
                Card c =  mainDeck.getCard();
                deck.Add(c);
            }
        }
        /// <summary>
        /// Adds an opponents cards to their deck
        /// </summary>
        private void AddOpponentCards()
        {
            //Add 4 cards for Opponents card deck
            for (int i = 0; i < 4; i++)
            {
                Card c = mainDeck.getCard();
                opponentDeck.Add(c);

            }
        }
        /// <summary>
        /// Adds the marketdeck cards to the marketdeck
        /// </summary>
        private void AddMarketCards()
        {
            //add 5 cards for the market
            for(int i = 0; i < 5; i++)
            {
                Card c = mainDeck.getCard();
                marketDeck.Add(c);
            }
        }
        /// <summary>
        /// Adds pyramiddeck cards to pramid deck
        /// </summary>
        private void AddPyramidCards()
        {
            //add 3 cards for small pyramid
            for (int i = 0; i < 3; i++)
            {
                Card s = mainDeck.getCard();
                pyramidDeck.PyramidSmall.Add(s);
            }
            //add 3 cards for medium pyramid
            for (int i = 0; i < 5; i++)
            {
                Card m = mainDeck.getCard();
                pyramidDeck.PyramidMedium.Add(m);
            }
            //add 3 cards for large pyramid
            for (int i = 0; i < 7; i++)
            {
                Card l = mainDeck.getCard();
                pyramidDeck.PyramidLarge.Add(l);
            }
            foreach(Card d in pyramidDeck.PyramidSmall)
            {
                Console.WriteLine(d);
            }
            
        }
        /// <summary>
        /// Add sandstorm cards to the sandstrorm deck
        /// </summary>
        private void AddSandstormCards()
        {
            for (int i = 0; i < 6; i++)
            {
                mainDeck.Add(new Sanstorm("Sandstorm"));
            }
        }
        /// <summary>
        /// Add map cards to the main deck
        /// </summary>
        private void AddMapCards()
        {
            //creating 6 maps
            for (int i = 0; i < 6; i++)
            {
                mainDeck.Add(new Maps("Maps"));
            }
        }
        /// <summary>
        /// Add thief cards to the main deck
        /// </summary>
        private void AddThiefCards()
        {
            for(int i = 0; i < 8; i++)
            {
                mainDeck.Add(new Thief("Thief"));
            }

        }
        /// <summary>
        /// Hides or shows the opponents controls
        /// </summary>
        /// <param name="val">bool for whether Hidden or shown</param>
        private void HideOpponent(bool val)
        {
            if (val == false || val == true)
            {
                //hide the opponents listbox contents 
                listBoxOpponentsDeck.Items.Clear();
                //Disable the players buttons
                buttonDigOpponent.Enabled = val;
                buttonSellOpponent.Enabled = val;
                buttonTradeOpponenet.Enabled = val;
                buttonExploreOpponent.Enabled = val;
                buttonEndOppponent.Enabled = val;
                
            }
        }
        /// <summary>
        /// Hides or shows the player controls
        /// </summary>
        /// <param name="val">bool for whether Hidden or shown</param>
        private void HidePlayer(bool val)
        {
            if (val == false || val == true)
            {
                if(val == true)
                {
                    //hide the opponents listbox contents 
                    //deck.DisplayPlayerDeck(listBoxPlayersDeck);
                }
                //Disable the players buttons
                buttonDig.Enabled = val;
                buttonSell.Enabled = val;
                buttonTrade.Enabled = val;
                buttonExplore.Enabled = val;
                buttonEnd.Enabled = val;

            }

        }
        /// <summary>
        /// Starts a new game by dealing cards to the players and the market place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            //Sanstorm label
            label8.Text = "";
            //clearing all the decks 
            marketDeck.MarketDeckList.Clear();
            deck.PlayersDeck.Clear();
            opponentDeck.OpponentsDeckList.Clear();
            mainDeck.MainDeckList.Clear();
            pyramidDeck.PyramidLarge.Clear();
            pyramidDeck.PyramidSmall.Clear();
            pyramidDeck.PyramidMedium.Clear();
            //bool variable for pyramid chambers used
            smallUsed = false;
            mediumUsed = false;
            largeUsed = false;
            
            //Creating a deck by calling the method
            createDeck();
            //Testing code
            foreach (Card c in mainDeck.CardsList)
            {
                Console.WriteLine(c);
            }
            
            //Add the players cards to the main deck
            AddPlayerCards();
            //Testing code
            foreach(Card c in deck.PlayersDeck)
            {
                Console.WriteLine(c.Name);
            }

            //displaying the players deck to the listbox
            deck.DisplayPlayerDeck(listBoxPlayersDeck);
            //adding opponents cards to the players deck
            AddOpponentCards();
            //displaying the opponent deck to its listbox
            opponentDeck.DisplayOpponentDeck(listBoxOpponentsDeck);
            //adding and displaying the marketdeck cards
            AddMarketCards();
            marketDeck.DisplayMarketDeck(listBoxMarket);
            //Adding pyramid, sandstorm, thief cards to the pyramid list
            AddPyramidCards();
            AddSandstormCards();
            AddThiefCards();
            AddMapCards();
            shuffle(mainDeck.MainDeckList.Count);
            foreach (Card c in mainDeck.MainDeckList)
            {
                Console.WriteLine(c);
            }



        }
        /// <summary>
        /// Sells a players selected items and adds total to total listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSell_Click(object sender, EventArgs e)
        {
            //if the current player has clicked sell loop through the list to add total
            int index2 = 0;
            bool dontMatch = false;
            string selectedName1 = "";
            string selectedName2 = "";
            //FOR each index position of the items that have been selected
            for (int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
            {
                //Get the index position of the current selected item
                index2 = listBoxPlayersDeck.SelectedIndices[i];
                //Get the card at the position from the cards list
                TreasureCard c = (TreasureCard)deck.PlayersDeck[index2];
                //if the card is a true remove half the deck
                if (sandstormSelected == true)
                {
                    for (int j = 0; j < halfinHand; j++)
                    {
                        deck.PlayersDeck.RemoveAt(j);
                    }
                }
                //if sandstorm selected is false
                else if (sandstormSelected == false)
                {
                    //if name 1 is not empty
                    if (selectedName1 != "")
                    {
                        selectedName2 = c.Name;
                    }
                    //if name 1 is empty
                    else if (selectedName1 == "")
                    {
                        selectedName1 = c.Name;
                    }
                    //if name1 and name 2 arent empty and arent the same
                    if (selectedName2 != selectedName1 && selectedName2 != "" && selectedName1 != "")
                    {
                        dontMatch = true;
                    }
                }
                
            }
            //for each selected player in the players deck
            for (int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
            {
                //if dont match is false
                if (dontMatch == false)
                {
                    //Get the index position of the current selected item
                    index2 = listBoxPlayersDeck.SelectedIndices[i];
                    //Get the card at the position from the cards list
                    TreasureCard c = (TreasureCard)deck.PlayersDeck[index2];
                    //remove the card
                    deck.PlayersDeck.Remove(c);
                }
            }
            // dont match is true
            if (dontMatch == true)
            {
                //display that selected cards arent the same type
                MessageBox.Show("Selected cards arent the same type");
            }
            else
            {
                if (selectedName1 == "Pot Shards")
                {
                    //if the count is 1 add 1 to the value
                    if (listBoxPlayersDeck.SelectedIndices.Count == 1)
                    {
                        totalValue += 1;
                    }
                    //if the count is 2 add 2 to the value
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 2)
                    {
                        totalValue += 2;
                    }
                    //if the count is 3 add 3 to the value
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 3)
                    {
                        totalValue += 3;
                    }
                    //if the count is 4 add 4 to the value
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 4)
                    {
                        totalValue += 4;
                    }
                    //if the count is 5 add 15 to the value
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 5)
                    {
                        totalValue += 15;
                    }
                }
                else if (selectedName1 == "Parchment Scraper")
                {
                    //for the count value add the specified value to the total
                    if (listBoxPlayersDeck.SelectedIndices.Count == 1)
                    {
                        totalValue += 1;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 2)
                    {
                        totalValue += 2;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 3)
                    {
                        totalValue += 3;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 4)
                    {
                        totalValue += 10;
                    }
                }
                else if (selectedName1 == "Coins")
                {
                    //for the count value add the specified value to the total
                    if (listBoxPlayersDeck.SelectedIndices.Count == 1)
                    {
                        totalValue += 2;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 2)
                    {
                        totalValue += 5;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 3)
                    {
                        totalValue += 10;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 4)
                    {
                        totalValue += 18;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 5)
                    {
                        totalValue += 30;
                    }
                }
                else if (selectedName1 == "Talismans")
                {
                    //for the count value add the specified value to the total
                    if (listBoxPlayersDeck.SelectedIndices.Count == 1)
                    {
                        totalValue += 3;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 2)
                    {
                        totalValue += 7;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 3)
                    {
                        totalValue += 14;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 4)
                    {
                        totalValue += 24;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 5)
                    {
                        totalValue += 40;
                    }
                }
                else if (selectedName1 == "Broken Cups")
                {
                    //for the count value add the specified value to the total
                    if (listBoxPlayersDeck.SelectedIndices.Count == 1)
                    {
                        totalValue += 2;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 2)
                    {
                        totalValue += 15;
                    }
                }
                else if (selectedName1 == "Maps")
                {
                    //for the count value add the specified value to the total
                    if (listBoxPlayersDeck.SelectedIndices.Count == 1)
                    {
                        totalValue += 3;
                    }
                }
                else if (selectedName1 == "Pharaohs Masks")
                {
                    //for the count value add the specified value to the total
                    if (listBoxPlayersDeck.SelectedIndices.Count == 1)
                    {
                        totalValue += 4;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 2)
                    {
                        totalValue += 12;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 3)
                    {
                        totalValue += 26;
                    }
                    else if (listBoxPlayersDeck.SelectedIndices.Count == 4)
                    {
                        totalValue += 50;
                    }
                }

            }
            //display the total to the player textbox
            textBoxPlayerBalance.Text = totalValue.ToString();
            //display the players deck
            deck.DisplayPlayerDeck(listBoxPlayersDeck);
            //clear the selected indices
            listBoxPlayersDeck.SelectedIndices.Clear();

            //if end game is reached
            if(deck.PlayersDeck.Count < 1 && opponentDeck.OpponentsDeckList.Count < 1)
            {
                //Display end game message 
                MessageBox.Show("End Game Reached");
                //close the game
                Application.Exit();

            }


        }
        /// <summary>
        /// Digs a card from the deck to the players hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDig_Click(object sender, EventArgs e)
        {
            //the total for the hand
            int totalinHand = 0;
            //random number 
            Random randThief = new Random();
            //add a single card for the player to object s
            Card s = mainDeck.getCard();

            

            //if the card was a sandstorm card make sure player removes half of hand
            if (s.Name == "Sandstorm")
            {
                foreach (Card c in deck.PlayersDeck)
                {
                    totalinHand++;
                }
                halfinHand = totalinHand / 2;
                MessageBox.Show("Sandstorm!!! You must lose half your hand: " + halfinHand.ToString());
                sandstormSelected = true;
                label8.Text = "SandStorm Card";
                for (int i = 0; i < halfinHand; i++)
                {
                    deck.PlayersDeck.RemoveAt(i);
                }

            }
            
            //if the card is a thief card
            else if(s.Name == "Thief" && opponentDeck.OpponentsDeckList.Count > 0)
            {
                MessageBox.Show("Thief!!! 1 card added to your hand");
                //get a random card from the opponents deck
                TreasureCard c = (TreasureCard)opponentDeck.OpponentsDeckList[randThief.Next(opponentDeck.OpponentsDeckList.Count)];
                //add it to your list
                deck.PlayersDeck.Add(c);
                //remove from opponents deck
                opponentDeck.OpponentsDeckList.Remove(c);
            }
            else if(s.Name == "Thief" && opponentDeck.OpponentsDeckList.Count < 1)
            {
                MessageBox.Show("Thief!!!");
            }
            else
            {
                deck.Add(s);
            }
            deck.DisplayPlayerDeck(listBoxPlayersDeck);
            opponentDeck.DisplayOpponentDeck(listBoxOpponentsDeck);
            //buttonDig.Enabled = false;
        }
        /// <summary>
        /// Trades a card for the player from the market place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTrade_Click(object sender, EventArgs e)
        {
            //if the current player has clicked sell loop through the list to add total
            int index1 = 0;
            int index2 = 0;
            int tpValue = 0;
            int tmValue = 0;
            List<int> removeMarket = new List<int>();
            List<int> removePlayer = new List<int>();

            //for each item in the players deck listbox that has been selected
            for (int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
            {
                //Get the index position of the current selected item
                index1 = listBoxPlayersDeck.SelectedIndices[i];
                //Get the card at the position from the cards list
                TreasureCard c = (TreasureCard)deck.PlayersDeck[index1];
                //get the total worth
                //sum the total selling
                tpValue += c.TradingValue;

            }
            //for each item in the marketplace that has been selected
            for (int i = 0; i < listBoxMarket.SelectedIndices.Count; i++)
            {
                //Get the index position of the current selected item
                index2 = listBoxMarket.SelectedIndices[i];
                //Get the card at the position from the cards list
                TreasureCard c = (TreasureCard)marketDeck.MarketDeckList[index2];
                //get the total worth
                //sum the total selling
                tmValue += c.TradingValue;

            }
            //if the trading values are the same then swap them
            if(tpValue < tmValue)
            {
                //display an error message
                MessageBox.Show("The selected cards do match trading criteria");
                listBoxMarket.SelectedIndices.Clear();
                listBoxPlayersDeck.SelectedIndices.Clear();
            }
            else
            {
                //MessageBox.Show("The cards have the same value");
                //swap the cards
                //for each item in the marketplace that has been selected
                for (int i = 0; i < listBoxMarket.SelectedIndices.Count; i++)
                {
                    //Get the index position of the current selected item
                    index2 = listBoxMarket.SelectedIndices[i];
                    //Get the card at the position from the cards list
                    TreasureCard c = (TreasureCard)marketDeck.MarketDeckList[index2];
                    //add the selected card to the players deck
                    deck.Add(c);
                    //remove the card from the market deck
                    //marketDeck.MarketDeckList.Remove(c);
                    removeMarket.Add(index2);
                    
                }
                //for each item in the players deck listbox that has been selected
                for (int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
                {
                    //Get the index position of the current selected item
                    index1 = listBoxPlayersDeck.SelectedIndices[i];
                    //Get the card at the position from the cards list
                    TreasureCard c = (TreasureCard)deck.PlayersDeck[index1];
                    //add the selected card to the market
                    marketDeck.Add(c);
                    //remove the card from the players
                    //deck.PlayersDeck.Remove(c);
                    removePlayer.Add(index1);
                }
                //foreach item in the market list remove the items
                for(int i = 0; i < removeMarket.Count; i++)
                {
                    marketDeck.MarketDeckList.RemoveAt(removeMarket[i]);
                }
                //foreach item in the player list remove the items
                for (int i = 0; i < removePlayer.Count; i++)
                {
                    deck.PlayersDeck.RemoveAt(removePlayer[i]);
                }
                //update the displays and clear the selected items
                deck.DisplayPlayerDeck(listBoxPlayersDeck);
                marketDeck.DisplayMarketDeck(listBoxMarket);
                listBoxMarket.SelectedIndices.Clear();
                listBoxPlayersDeck.SelectedIndices.Clear();
            }
        }
        /// <summary>
        /// Allows a player to explore a pyramid chamber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExplore_Click(object sender, EventArgs e)
        {
            //declare variables
            int index1 = 0;
            bool mapSelected = false;
            int mapTotal = 0;
            //for each item in the players deck listbox that has been selected
            for (int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
            {
                //Get the index position of the current selected item
                index1 = listBoxPlayersDeck.SelectedIndices[i];
                //Get the card at the position from the cards list
                TreasureCard c = (TreasureCard)listBoxPlayersDeck.Items[index1];
                //get the map cards
                if (c.Name == "Maps" )
                {
                    //add to the map total set selected to true
                    mapSelected = true;
                    mapTotal++;
                    
                }
                if(c.Name == " Maps" && (smallUsed == false|| mediumUsed == false || largeUsed == false))
                {
                    //remove the card from the deck
                    deck.PlayersDeck.Remove(c);
                }
            }
            if(mapSelected == false )
            {
                //display error message
                MessageBox.Show("No Map selected");
            }
            if(smallUsed == true || mediumUsed == true || largeUsed == true)
            {
                //display message
                MessageBox.Show("Pyramid has been used already");
            }
            //if the map total is 1 card give the player 3 cards from the pyramid
            else if (mapTotal == 1 && smallUsed == false)
            {
                MessageBox.Show("1 Map selected");
                for(int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
                {
                    //for each items in small add it to the players listbox
                    for(int j = 0; j < pyramidDeck.PyramidSmall.Count; j++)
                    {
                        //add contents to listbox
                        deck.PlayersDeck.Add(pyramidDeck.PyramidSmall[j]);
                    }
                   

                }
                smallUsed = true;
            }
            else if (mapTotal == 2 && mediumUsed == false)
            {
                //Display message
                MessageBox.Show("2 Maps selected");
                //foreach selected item in the listbox
                for (int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
                {
                    //for each items in medium add it to the players listbox
                    for (int j = 0; j < pyramidDeck.PyramidMedium.Count; j++)
                    {
                        //add contents to listbox
                        deck.PlayersDeck.Add(pyramidDeck.PyramidMedium[j]);
                    }

                }
            }
            else if (mapTotal == 3 && largeUsed == false)
            {
                //display message
                MessageBox.Show("3 Maps selected");
                //foreach item in playerdeck
                for (int i = 0; i < listBoxPlayersDeck.SelectedIndices.Count; i++)
                {
                    //for each items in large add it to the players listbox
                    for (int j = 0; j < pyramidDeck.PyramidLarge.Count; j++)
                    {
                        //add contents to listbox
                        deck.PlayersDeck.Add(pyramidDeck.PyramidLarge[j]);
                    }

                }
            }

            //update the displays and clear the indices
            deck.DisplayPlayerDeck(listBoxPlayersDeck);
            marketDeck.DisplayMarketDeck(listBoxMarket);
            listBoxMarket.SelectedIndices.Clear();
            listBoxPlayersDeck.SelectedIndices.Clear();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEndOppponent_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonSandstormPlayer_Click(object sender, EventArgs e)
        {

        }

        private void buttonStartPlayPlayer_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Sells an opponents cards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellOpponent_Click(object sender, EventArgs e)
        {
            //declarig index, bool, string variables
            int index2 = 0;
            bool dontMatch = false;
            string selectedName1 = "";
            string selectedName2 = "";
            //FOR each index position of the items that have been selected
            for (int i = 0; i < listBoxOpponentsDeck.SelectedIndices.Count; i++)
            {
                //Get the index position of the current selected item
                index2 = listBoxOpponentsDeck.SelectedIndices[i];
                //Get the card at the position from the cards list
                TreasureCard c = (TreasureCard)opponentDeck.OpponentsDeckList[index2];
                //if sanstrom is true
                if (sandstormSelected == true)
                {
                    //remove half the hand
                    for (int j = 0; j < halfinHand; j++)
                    {
                        opponentDeck.OpponentsDeckList.RemoveAt(j);
                    }

                }
                else if (sandstormSelected == false)
                {
                    //if name 1 is not empty set the name2
                    if (selectedName1 != "")
                    {
                        selectedName2 = c.Name;
                    }
                    //if name 1 is  empty set the name1
                    else if (selectedName1 == "")
                    {
                        selectedName1 = c.Name;
                    }
                    //if not empty and differrent
                    if (selectedName2 != selectedName1 && selectedName2 != "" && selectedName1 != "")
                    {
                        dontMatch = true;
                    }
                }

            }

            //For each selected opponent index
            for (int i = 0; i < listBoxOpponentsDeck.SelectedIndices.Count; i++)
            {
                //
                if (dontMatch == false)
                {
                    //Get the index position of the current selected item
                    index2 = listBoxOpponentsDeck.SelectedIndices[i];
                    //Get the card at the position from the cards list
                    TreasureCard c = (TreasureCard)opponentDeck.OpponentsDeckList[index2];
                    opponentDeck.OpponentsDeckList.Remove(c);
                }
            }
            if (dontMatch == true)
            {
                //display message
                MessageBox.Show("Selected cards arent the same type");
            }
            else
            {
            if (selectedName1 == "Pot Shards")
            {
                //if its a potshard add the amounts
                if (listBoxOpponentsDeck.SelectedIndices.Count == 1)
                {
                    totalValue2 += 1;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 2)
                {
                    totalValue2 += 2;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 3)
                {
                    totalValue2 += 3;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 4)
                {
                    totalValue2 += 4;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 5)
                {
                    totalValue2 += 15;
                }
            }
            else if (selectedName1 == "Parchment Scraper")
            {
                //add potshard total
                if (listBoxOpponentsDeck.SelectedIndices.Count == 1)
                {
                    totalValue2 += 1;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 2)
                {
                    totalValue2 += 2;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 3)
                {
                    totalValue2 += 3;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 4)
                {
                    totalValue2 += 10;
                }
            }
            else if (selectedName1 == "Coins")
            {
                //add coins total
                if (listBoxOpponentsDeck.SelectedIndices.Count == 1)
                {
                    totalValue2 += 2;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 2)
                {
                    totalValue2 += 5;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 3)
                {
                    totalValue2 += 10;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 4)
                {
                    totalValue2 += 18;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 5)
                {
                    totalValue2 += 30;
                }
            }
            else if (selectedName1 == "Talismans")
            {
                //add talismans total
                if (listBoxOpponentsDeck.SelectedIndices.Count == 1)
                {
                    totalValue2 += 3;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 2)
                {
                    totalValue2 += 7;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 3)
                {
                    totalValue2 += 14;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 4)
                {
                    totalValue2 += 24;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 5)
                {
                    totalValue2 += 40;
                }
            }
            else if (selectedName1 == "Broken Cups")
            {
                //add cups total
                if (listBoxOpponentsDeck.SelectedIndices.Count == 1)
                {
                    totalValue2 += 2;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 2)
                {
                    totalValue2 += 15;
                }
            }
            else if (selectedName1 == "Maps")
            {
                //add Maps total
                if (listBoxOpponentsDeck.SelectedIndices.Count == 1)
                {
                    totalValue2 += 3;
                }
            }
            else if (selectedName1 == "Pharaohs Masks")
            {
                //add mask total
                if (listBoxOpponentsDeck.SelectedIndices.Count == 1)
                {
                    totalValue2 += 4;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 2)
                {
                    totalValue2 += 12;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 3)
                {
                    totalValue2 += 26;
                }
                else if (listBoxOpponentsDeck.SelectedIndices.Count == 4)
                {
                    totalValue2 += 50;
                }
            }
                //}

            }
            textBoxOpponentBalance.Text = totalValue2.ToString();

            opponentDeck.DisplayOpponentDeck(listBoxOpponentsDeck);


            listBoxOpponentsDeck.SelectedIndices.Clear();

            //if both lists are empty 
            if (deck.PlayersDeck.Count < 1 && opponentDeck.OpponentsDeckList.Count < 1)
            {
                MessageBox.Show("End Game Reached");
                Application.Exit();

            }

        }
        /// <summary>
        /// trades a card from the market place to the opponents hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTradeOpponenet_Click(object sender, EventArgs e)
        {
            //declare variabels
            int index1 = 0;
            int index2 = 0;
            int tpValue = 0;
            int tmValue = 0;
            List<int> removeMarket = new List<int>();
            List<int> removeOpponent = new List<int>();

            //for each item in the players deck listbox that has been selected
            for (int i = 0; i < listBoxOpponentsDeck.SelectedIndices.Count; i++)
            {
                //Get the index position of the current selected item
                index1 = listBoxOpponentsDeck.SelectedIndices[i];
                //Get the card at the position from the cards list
                TreasureCard c = (TreasureCard)opponentDeck.OpponentsDeckList[index1];
                //get the total worth
                //sum the total selling
                tpValue += c.TradingValue;

            }
            //for each item in the marketplace that has been selected
            for (int i = 0; i < listBoxMarket.SelectedIndices.Count; i++)
            {
                //Get the index position of the current selected item
                index2 = listBoxMarket.SelectedIndices[i];
                //Get the card at the position from the cards list
                TreasureCard c = (TreasureCard)marketDeck.MarketDeckList[index2];
                //get the total worth
                //sum the total selling
                tmValue += c.TradingValue;

            }
            //if the trading values are the same then swap them
            if (tpValue < tmValue)
            {
                //display an error message
                MessageBox.Show("The selected cards do match trading criteria");
                listBoxMarket.SelectedIndices.Clear();
                listBoxOpponentsDeck.SelectedIndices.Clear();
            }
            else
            {
                //for each item in the marketplace that has been selected
                for (int i = 0; i < listBoxMarket.SelectedIndices.Count; i++)
                {
                    //Get the index position of the current selected item
                    index2 = listBoxMarket.SelectedIndices[i];
                    //Get the card at the position from the cards list
                    TreasureCard c = (TreasureCard)marketDeck.MarketDeckList[index2];
                    //add the selected card to the players deck
                    opponentDeck.Add(c);
                    //remove the card from the market deck
                    //marketDeck.MarketDeckList.Remove(c);
                    removeMarket.Add(index2);

                }
                //for each item in the players deck listbox that has been selected
                for (int i = 0; i < listBoxOpponentsDeck.SelectedIndices.Count; i++)
                {
                    //Get the index position of the current selected item
                    index1 = listBoxOpponentsDeck.SelectedIndices[i];
                    //Get the card at the position from the cards list
                    TreasureCard c = (TreasureCard)opponentDeck.OpponentsDeckList[index1];
                    //add the selected card to the market
                    marketDeck.Add(c);
                    //remove the card from the players
                    //deck.PlayersDeck.Remove(c);
                    removeOpponent.Add(index1);
                }
                //foreach item in the market list remove the items
                for (int i = 0; i < removeMarket.Count; i++)
                {
                    marketDeck.MarketDeckList.RemoveAt(removeMarket[i]);
                }
                //foreach item in the player list remove the items
                for (int i = 0; i < removeOpponent.Count; i++)
                {
                    opponentDeck.OpponentsDeckList.RemoveAt(removeOpponent[i]);
                }
                //update the display
                opponentDeck.DisplayOpponentDeck(listBoxOpponentsDeck);
                marketDeck.DisplayMarketDeck(listBoxMarket);
                listBoxMarket.SelectedIndices.Clear();
                listBoxOpponentsDeck.SelectedIndices.Clear();
            }
        }
        /// <summary>
        /// Digs a card for the opponents hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDigOpponent_Click(object sender, EventArgs e)
        {
            int totalinHand = 0;
            Random randThief = new Random();
            //add a single card for the player
            Card s = mainDeck.getCard();



            //if the card was a sandstorm card make sure player removes half of hand
            if (s.Name == "Sandstorm")
            {
                foreach (Card c in opponentDeck.OpponentsDeckList)
                {
                    totalinHand++;
                }
                halfinHand = totalinHand / 2;
                MessageBox.Show("Sandstorm!!! You must lose half your hand: " + halfinHand.ToString());
                //sandstormSelected = true;
                label8.Text = "SandStorm Card";
                for(int i = 0; i < halfinHand; i++)
                {
                    opponentDeck.OpponentsDeckList.RemoveAt(i);
                }

            }

            //if the card is a thief card
            else if (s.Name == "Thief" && opponentDeck.OpponentsDeckList.Count > 0)
            {
                MessageBox.Show("Thief!!! 1 card added to your hand");
                //get a random card from the opponents deck
                TreasureCard c = (TreasureCard)opponentDeck.OpponentsDeckList[randThief.Next(opponentDeck.OpponentsDeckList.Count)];
                //add it to your list
                //remove from opponents deck
                opponentDeck.OpponentsDeckList.Add(c);
                deck.PlayersDeck.Remove(c);
            }
            else if (s.Name == "Thief" && opponentDeck.OpponentsDeckList.Count < 1)
            {
                MessageBox.Show("Thief!!!");
            }
            else
            {
                opponentDeck.OpponentsDeckList.Add(s);
            }
            deck.DisplayPlayerDeck(listBoxPlayersDeck);
            opponentDeck.DisplayOpponentDeck(listBoxOpponentsDeck);
            //buttonDig.Enabled = false;
        }
    }
}
