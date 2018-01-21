using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HareAndTortoise {
    
    public class Square_Chance : Square {

        const int AMOUNT_MONEY = 50;

        /// <summary>
        /// square chance sub class
        /// </summary>
        /// <param name="name">square chance name</param>
        /// <param name="number">square chance number</param>
        public Square_Chance(string name, int number)
            : base(name, number) { }

        public override void EffectOnPlayer(Player who) {
            Random random = new Random();
            int randomNumber = random.Next(0, 1);
            if (randomNumber == 0) {
                who.Add(AMOUNT_MONEY);
            } else {
                who.Deduct(AMOUNT_MONEY);
            }
        }
    }
}
