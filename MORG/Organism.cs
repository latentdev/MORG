using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORG
{
    class Organism
    {
        protected MoveBehavior movebehavior;
        protected char type;
        protected int x;
        protected int y;

        public void PerformMove()
        {
            movebehavior.move();
        }
    }

    class ORG_A : Organism
    {

        public ORG_A()
        {
            type = 'a';
            x = 0;
            y = 0;
            Console.Write("Organism A ");
            movebehavior = new Paddles();
        }
    }

    class ORG_B : Organism
    {
        public ORG_B()
        {
            type = 'b';
            x = 10;
            y = 10;
            Console.Write("Organism B ");
            movebehavior = new Oozes();
        }
    }

    class ORG_C : Organism
    {
        public ORG_C()
        {
            type = 'c';
            x = 5;
            y = 5;
            Console.Write("Organism C ");
            movebehavior = new Paddles();
        }
    }

}
