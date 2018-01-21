using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HareAndTortoise {
    public class Square_Lose : Square {

        const int AMOUNT_DEDUCT = 25;

        /// <summary>
        /// square lose sub class
        /// </summary>
        /// <param name="name">square lose name</param>
        /// <param name="number">square lose number</param>
        public Square_Lose(string name, int number)
            : base(name, number) { }
        public override void EffectOnPlayer(Player who) {
            who.Deduct(AMOUNT_DEDUCT);
        }
    }
}
