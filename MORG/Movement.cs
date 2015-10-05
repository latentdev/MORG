using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORG
{
    interface MoveBehavior
    {
        void move();
    }

    class Oozes : MoveBehavior
    {
        public void move()
        {
            Console.WriteLine("Oozes");
        }
    }

    class Paddles : MoveBehavior
    {
        public void move()
        {
            Console.WriteLine("Paddles");
        }
    }
}
