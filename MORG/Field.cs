using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORG
{
    class Field
    {
        int x_size;
        int y_size;

        Field()
        {
            x_size = 10;
            y_size = 10;
        }

        Field(int x,int y)
        {
            x_size = x;
            y_size = y;
        }
    }
}
