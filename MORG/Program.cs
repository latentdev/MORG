using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MORG
{
    class Program
    {
        static void Main(string[] args)
        {
            Organism a = new ORG_A();
            a.PerformMove();
            a = new ORG_B();
            a.PerformMove();
            a = new ORG_C();
            a.PerformMove();
        }
    }
}
