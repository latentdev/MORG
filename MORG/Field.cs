﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORG
{
    class Field
    {
        protected int x_size;
        protected int y_size;
        public Random n = new Random();

        public Field()
        {
            x_size = 10;
            y_size = 10;
        }

        public Field(int x,int y)
        {
            x_size = x;
            y_size = y;
        }

        public int Getx_size()
        {
            return x_size;
        }

        public int Gety_size()
        {
            return y_size;
        }
    }
}
