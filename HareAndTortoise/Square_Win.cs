using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HareAndTortoise {
    public class Square_Win  : Square {

        const int AMOUNT_ADD = 15;
        /// <summary>
        /// square win sub class
        /// </summary>
        /// <param name="name">square win name</param>
        /// <param name="number">square win number</param>
        public Square_Win(string name, int number)
                : base(name, number) { }

        public override void EffectOnPlayer(Player who) {
            who.Add(AMOUNT_ADD);
        }
    }
    }

