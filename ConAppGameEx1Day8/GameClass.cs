using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppGameEx1Day8
{
    public class GameClass
    {
         
        public void Initial()
        {
           static int elevel = 1;
           static int probability = 100;
        }
        public void Firstspin()
        {
            elevel = elevel + 1;
            probability += probability + 10;
        }
        public void Secondspin()
        {
            elevel = elevel + 2;
            probability += probability + 20;
        }
        public void Thirdspin()
        {
            elevel = elevel - 3;
            probability += probability - 30;
        }
        public void Fourthtspin()
        {
            elevel = elevel + 4;
            probability += probability + 0;
        }
       
        public void Fifthspin()
        {
            elevel = elevel - 5;
            probability += probability -50;
        }
        public void Sixthspin()
        {
            elevel = elevel - 1;
            probability += probability - 60;
        }
        public void Seventhspin()
        {
            elevel += elevel + 1;
            probability += probability + 70;
        }
        public void Eighthspin()
        {
            elevel += elevel - 2;
            probability += probability - 20;
        }
        public void Ninthspin()
        {
            elevel += elevel - 3;
            probability += probability - 30;
        }
        public void Tenthspin()
        {
            elevel += elevel + 10;
            probability += probability + 100;
        }
    }
}
