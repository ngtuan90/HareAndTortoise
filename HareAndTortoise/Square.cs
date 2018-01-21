using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HareAndTortoise {

    public class Square {
        private string name;
        private int number;

        /// <summary>
        /// defalt square class
        /// </summary>
        public Square() {
            throw new ArgumentException("this use is invalid");
        }

        /// <summary>
        /// square class
        /// </summary>
        /// <param name="name">square name</param>
        /// <param name="number">square number</param>
        public Square(string name, int number) {
            this.name = name;
            this.number = number;
        }
        /// <summary>
        /// set name value and return
        /// </summary>
        public string Name {
            set {
                name = value;
            }
            get {
                return name;
            }
        }

        /// <summary>
        /// set number value and return
        /// </summary>
        public int Number {
            set {
                number = value;
            }
            get {
                return number;
            }
        }

        public virtual void EffectOnPlayer(Player who) {

        }
    }




}



