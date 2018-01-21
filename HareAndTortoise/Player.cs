using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTProject;
using System.Drawing;

namespace HareAndTortoise {

    public class Player {
        private string name;
        private Square location;
        private Image playerTokenImage;
        private Brush playerTokenColour;
        private int money = 100;
        private bool hasWon;

        private int numberOfPlayers;


        /// <summary>
        /// defalt player class
        /// </summary>
        public Player() {
            throw new ArgumentException("its use is invalid");
        }
        /// <summary>
        /// Player class
        /// </summary>
        /// <param name="name">player name</param>
        /// <param name="location">location of square</param>
        public Player(string name, Square location) {
            this.name = name;
            this.location = location;
        }




        /// <summary>
        /// Initialise name and return name value
        /// </summary>
        public string Name {
            set { name = value; }
            get { return name; }
        }
        /// <summary>
        /// Initialise money and return money value
        /// </summary>
        public int Money {
            set { money = value; }
            get { return money; }
        }
        /// <summary>
        /// Initialise haswon and return haswon valid
        /// </summary>
        public bool HasWon {
            set { hasWon = value; }
            get { return hasWon; }
        }
        /// <summary>
        /// Initialise location and return location value
        /// </summary>
        public Square Location {
            set { location = value; }
            get { return location; }
        }
        /// <summary>
        /// only return value player token image
        /// </summary>
        public Image PlayerTokenImage {
            get { return playerTokenImage; }
        }
        /// <summary>
        /// Initialise player token colour and return player token colour value
        /// </summary>
        public Brush PlayerTokenColour {
            set {
                playerTokenColour = value;
                playerTokenImage = new Bitmap(1, 1);
                using (Graphics g = Graphics.FromImage(PlayerTokenImage)) {
                    g.FillRectangle(playerTokenColour, 0, 0, 1, 1);
                }
            }
            get { return playerTokenColour; }
            
        }
        /// <summary>
        /// Player roll 2 dice
        /// </summary>
        /// <returns> total value of 2 dice faces</returns>
        public int RollTheDice() {
            
            return HareAndTortoise_Game.die1.Roll() + HareAndTortoise_Game.die2.Roll();
            
        }

        public void Add(int amount) {
            money = money + amount;
        }
        public void Deduct(int amount) {
            if(money > 0) {
                money = money - amount;
            } else {
                money = 0;
            }
        }
    }
}


