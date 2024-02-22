using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Trie
{
    public class CNode
    {
        internal int data;
        protected int letterValue;
        internal CNode prev;
        internal CNode next;
        public CNode(string letter)
        {
            

            switch (letter)
            {
                case "A":
                    this.letterValue = 1;
                    break;
                case "B":
                    this.letterValue = 3;
                    break;
                case "C":
                    this.letterValue = 3;
                    break;
                case "D":
                    this.letterValue = 2;
                    break;
                case "E":
                    this.letterValue = 1;
                    break;
                case "F":
                    this.letterValue = 4;
                    break;
                case "G":
                    this.letterValue = 2;
                    break;
                case "H":
                    this.letterValue = 4;
                    break;
                case "I":
                    this.letterValue = 1;
                    break;
                case "J":
                    this.letterValue = 8;
                    break;
                case "K":
                    this.letterValue = 5;
                    break;
                case "L":
                    this.letterValue = 1;
                    break;
                case "M":
                    this.letterValue = 3;
                    break;
                case "N":
                    this.letterValue = 1;
                    break;
                case "O":
                    this.letterValue = 1;
                    break;
                case "P":
                    this.letterValue = 3;
                    break;
                case "Q":
                    this.letterValue = 10;
                    break;
                case "R":
                    this.letterValue = 1;
                    break;
                case "S":
                    this.letterValue = 1;
                    break;
                case "T":
                    this.letterValue = 1;
                    break;
                case "U":
                    this.letterValue = 1;
                    break;
                case "V":
                    this.letterValue = 4;
                    break;
                case "W":
                    this.letterValue = 4;
                    break;
                case "X":
                    this.letterValue = 8;
                    break;
                case "Y":
                    this.letterValue = 4;
                    break;
                case "Z":
                    this.letterValue = 10;
                    break;
            }
        }
    }
}






























