using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HareAndTortoise {

    public static class Board {
        const int START_NUMBER = 0;
        const int FINISH_NUMBER = 55;
         const int NUMBER_SQUARE = 56;
        //set up list for lose, win and chance
        static readonly List<int> LIST_LOSE_NUMBER = new List<int> { 10 , 20, 30, 40, 50};
        static readonly List<int> LIST_WIN_NUMBER = new List<int> { 5, 15, 25, 35, 45 };
        static readonly List<int> LIST_CHANCE_NUMBER = new List<int> { 6, 12, 18, 24, 36, 42, 48, 54 };
        private static Square[] gameBoard;

        /// <summary>
        /// set up the board based on number each square
        /// </summary>
        public static void SetUpBoard() {
            gameBoard = new Square[NUMBER_SQUARE];
            // check number of each square is lose, win, start, finish or chance square
            for (int i = START_NUMBER; i <= FINISH_NUMBER; i++) {
                if (i == START_NUMBER) {
                    gameBoard[i] = new Square("Start", i);
                } else if (i == FINISH_NUMBER) {
                    gameBoard[i] = new Square("Finish", i);
                } else if (LIST_LOSE_NUMBER.Contains(i)) {
                    gameBoard[i] = new Square_Lose(i.ToString(), i);
                } else if (LIST_WIN_NUMBER.Contains(i)) {
                    gameBoard[i] = new Square_Win(i.ToString(), i);
                } else if (LIST_CHANCE_NUMBER.Contains(i)) {
                    gameBoard[i] = new Square_Chance(i.ToString(), i);
                } else {
                    gameBoard[i] = new Square(i.ToString(), i);
                }
            }

        }
        /// <summary>
        /// Get the game board square
        /// </summary>
        /// <param name="index">number of square</param>
        /// <returns>specific game board with number </returns>
        public static Square GetGameBoardSquare(int index) {
            try { 
                return gameBoard[index];
            } catch { 
                throw new Exception("this is not a valid square number");
            }
        }
        /// <summary>
        /// start game board square
        /// </summary>
        /// <returns>board game which have start</returns>
        public static Square StartSquare() {
            return gameBoard[START_NUMBER];
        }
        /// <summary>
        /// set next square
        /// </summary>
        /// <param name="index">square number</param>
        /// <returns>return next square</returns>
        public static Square NextSquare(int index) {
            try {  
                return gameBoard[index + 1];
            } catch { 
                throw new Exception("this is not a valid square number");
            }
        }
    }
}
