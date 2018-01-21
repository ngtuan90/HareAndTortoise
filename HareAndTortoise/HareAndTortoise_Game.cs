using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace HareAndTortoise {
    public static class HareAndTortoise_Game {
        const int NUMBER_SQUARE = 56;
        //private static HareAndTortoise_Form hareAndTortoise_Form;
        private static int numberOfPlayers =6;
        
        // create array about player name and player colour
        private static string[] Player_Name_Arr = new string[] { "One", "Two", "Three", "Four", "Five", "Six" };
        private static Brush[] Player_Colour_Arr = new Brush[] { Brushes.Black, Brushes.Red, Brushes.Gold, Brushes.GreenYellow, Brushes.Fuchsia, Brushes.BlueViolet };

        //private static HareAndTortoise_Form hareAndTortoise_Form = new HareAndTortoise_Form();

        public static int NumberOfPlayers {
            set { numberOfPlayers = value; }
            get { return numberOfPlayers; }
        }




        // declare 2 die in Die class
        public static Die die1 = new Die();
        public static Die die2 = new Die();

        private static BindingList<Player> players = new BindingList<Player>();
        public static BindingList<Player> Players {
            get {
                return players;
            }
        }

        public static int GetNumberPlayer(HareAndTortoise_Form form) {
            return form.GetInputComboBox();
        }

        /// <summary>
        /// set up game board
        /// </summary>
        public static void SetUpGame() {
            players.Clear();
            Board.SetUpBoard();
            
            for (int i = 0; i < numberOfPlayers; i++) {
                Player player = new Player(Player_Name_Arr[i], Board.StartSquare());
                player.PlayerTokenColour = Player_Colour_Arr[i];
                players.Add(player);

            }
        }
        // end SetUpGame

        /// <summary>
        /// reassign the player location base on the value of the rolled dice
        /// </summary>
        public static void PlayOneRound() {
            for (int i = 0; i < numberOfPlayers; i++) {


                int boardLocation = players[i].Location.Number + players[i].RollTheDice();
                if (boardLocation < NUMBER_SQUARE) {
                    players[i].Location = Board.GetGameBoardSquare(boardLocation);
                } else {
                    players[i].Location = Board.GetGameBoardSquare(NUMBER_SQUARE - 1);
                }
                players[i].Location.EffectOnPlayer(players[i]);
            }
            for (int i = 0; i < numberOfPlayers; i++) {
                if (players[i].Location.Number == (NUMBER_SQUARE - 1)) {
                    Player playerWin = players[0];
                    for (int j = 1; j < 6; j++) {

                        if (playerWin.Money < players[j].Money) {
                            playerWin = players[j];
                        }

                    }
                    playerWin.HasWon = true;
                    for (int j = 1; j < 6; j++) {
                        if (playerWin.Money == players[j].Money) {
                            if (playerWin.Location.Number < players[j].Location.Number) {
                                playerWin.HasWon = false;
                                players[j].HasWon = true;
                            } else if (playerWin.Location.Number == players[j].Location.Number) {
                                players[j].HasWon = true;
                            }
                        }
                    
                    }
                }
            }
        }



            /// <summary>
            /// Output all players details
            /// </summary>
            public static void OutputAllPlayerDetails() {
            for (int i = 0; i < numberOfPlayers; i++) {
                OutputIndividualDetails(Players[i]);
            }
        } // end OutputAllPlayerDetails

          /// <summary>
          /// Outputs a player's current location and amount of money
          /// pre: player's object to display
          /// post: displayed the player's location and amount
          /// </summary>
          /// <param name="who">the player to display</param>
        public static void OutputIndividualDetails(Player who) {
            Square playerLocation = who.Location;
            Trace.WriteLine(String.Format("Player {0} on square {1} with {2:C}",
            who.Name, playerLocation.Name, who.Money));
        } // end OutputIndividualDetails

    }//end class
}//end namespace
