using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
/*
 * Name: Hoang Minh Nguyen (Jackie)
 * Student number: n9930191
 * 
 * Name: Tien Khai Nguyen (kyle)
 * Student number: n9913998
 * 
 * 
 */

namespace HareAndTortoise {
    public partial class HareAndTortoise_Form : Form {




        const int NUM_OF_ROWS = 8;
        const int NUM_OF_COLUMNS = 7;
        const int NUM_START = 0;
        const int NUM_FINISH = 55;
        const int NUM_SQUARE = 56;
        int numberOfPlayers = 6;



        /// <summary>
        /// Hare and tortoise_form
        /// </summary>
        public HareAndTortoise_Form() {

            InitializeComponent();
            HareAndTortoise_Game.SetUpGame();
            ResizeGameBoard();
            SetUpGuiGameBoard();
            playerBindingSource.DataSource = HareAndTortoise_Game.Players;
            UpdateGuiPlayerSquare(true);
            Trace.Listeners.Add(new ListBoxTraceListener(LstBox));
        }
        /// <summary>
        /// Set up GUI game board square
        /// </summary>
        private void SetUpGuiGameBoard() {

            // for each square that is on the game board 
            //      obtain the Square object associated with the square
            //      create a SquareControl object (ie call Constructor)
            //      if the square is either Start square or Finish square
            //         set the BackColor of the SquareControl to BurlyWood
            //      otherwise do not set the BackColor
            //      Determine the correct position (cell) in the TablelayoutPanel of the square
            //      Add the SquareControl object to that position of the TableLayoutPanel
            int row, column;
            //get the determined square to each TableLayoutPanel
            for (int number = 0; number < NUM_SQUARE; number++) {
                SquareControl squareControl = new SquareControl(Board.GetGameBoardSquare(number), HareAndTortoise_Game.Players);
                if (number == NUM_START || number == NUM_FINISH) {
                    squareControl.BackColor = Color.BurlyWood;
                }

                MapSquareToTablePanel(number, out row, out column);


                gameBoardPanel.Controls.Add(squareControl, column, row);

            }
        }//end SetUpGuiGameBoard()


        /// <summary>
        /// resize game board square
        /// </summary>
        private void ResizeGameBoard() {
            const int SQUARE_SIZE = SquareControl.SQUARE_SIZE;
            int currentHeight = gameBoardPanel.Size.Height;
            int currentWidth = gameBoardPanel.Size.Width;
            int desiredHeight = SQUARE_SIZE * NUM_OF_ROWS;
            int desiredWidth = SQUARE_SIZE * NUM_OF_COLUMNS;
            int increaseInHeight = desiredHeight - currentHeight;
            int increaseInWidth = desiredWidth - currentWidth;
            this.Size += new Size(increaseInWidth, increaseInHeight);
            gameBoardPanel.Size = new Size(desiredWidth, desiredHeight);
        } //end ResizeGameBoard


        /// <summary>
        /// determine the correct position in TableLayoutPanel of the square
        /// </summary>
        /// <param name="number">square number</param>
        /// <param name="row">row of TableLayoutPanel</param>
        /// <param name="column">column of TableLayourPanel</param>
        private static void MapSquareToTablePanel(int number, out int row, out int column) {
            row = (NUM_OF_ROWS - 1) - (number / NUM_OF_COLUMNS);
            if (row % 2 != 0) {
                column = number % NUM_OF_COLUMNS;
            } else {
                column = (NUM_OF_COLUMNS - 1) - (number % NUM_OF_COLUMNS);
            }
        }
        //    switch (number / 7) {
        //        case 0:
        //            row = 7;
        //            break;
        //        case 1:
        //            row = 6;
        //            break;
        //        case 2:
        //            row = 5;
        //            break;
        //        case 3:
        //            row = 4;
        //            break;
        //        case 4:
        //            row = 3;
        //            break;
        //        case 5:
        //            row = 2;
        //            break;
        //        case 6:
        //            row = 1;
        //            break;
        //        default:
        //            row = 0;
        //            break;

        //    }

        //    if (row % 2 != 0) {
        //        column = number % 7;
        //    } else {
        //        column = 6 - number % 7;
        //    }

        //}
        /// <summary>
        /// Relocate the player token into the board
        /// </summary>
        /// <param name="addOrNot">add the token or not</param>
        public void UpdateGuiPlayerSquare(bool addOrNot) {
            int row, column;
  
            for (int i = 0; i < numberOfPlayers; i++) {

                Square locationSquare = HareAndTortoise_Game.Players[i].Location;
                MapSquareToTablePanel(locationSquare.Number, out row, out column);
                //
                SquareControl squareControl = (SquareControl)gameBoardPanel.GetControlFromPosition(column, row);
                squareControl.ContainsPlayers[i] = addOrNot;
            }
            gameBoardPanel.Invalidate(true);
        }

        private void btnRollDice_Click(object sender, EventArgs e) {
            UpdateGuiPlayerSquare(false);
            HareAndTortoise_Game.PlayOneRound();
            UpdateGuiPlayerSquare(true);
            OutputPlayersDetails();
            UpdateDataGridView();
            cmbNumber.Enabled = false;
            for(int i=0; i <6; i++) {
                if(HareAndTortoise_Game.Players[i].Location.Number == NUM_FINISH) {
                    btnRollDice.Enabled = false;
                } 
                    
                
            }
            HareAndTortoise_Game.Players.ResetBindings();
        }

        /// <summary>
        /// display detail about each player
        /// </summary>
        private void OutputPlayersDetails() {
            HareAndTortoise_Game.OutputAllPlayerDetails();
            LstBox.Items.Add("");
            LstBox.SelectedIndex = LstBox.Items.Count - 1;
        }

        private void btnReset_Click(object sender, EventArgs e) {
            UpdateGuiPlayerSquare(false);
            HareAndTortoise_Game.SetUpGame();
            LstBox.Items.Clear();
            UpdateDataGridView();
            UpdateGuiPlayerSquare(true);
            btnRollDice.Enabled = true;
            cmbNumber.Enabled = true;
        }

        public void UpdateDataGridView() {
            HareAndTortoise_Game.Players.ResetBindings();

        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure?", "Do you really want to exit?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                this.Close();
            }
        }

        public int GetInputComboBox() {
            string numPlayers = cmbNumber.Text;
            int index = cmbNumber.FindString(numPlayers);
            // Set the selected index
            cmbNumber.SelectedIndex = index;
            return int.Parse(numPlayers);
        }

        private void cmbNumber_SelectedIndexChanged(object sender, EventArgs e) {
            var numPlayers = GetInputComboBox();
            HareAndTortoise_Game.NumberOfPlayers = numPlayers;
        }
    }//end class 
} //end namespace
