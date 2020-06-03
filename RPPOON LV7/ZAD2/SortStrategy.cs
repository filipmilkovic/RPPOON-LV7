﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    abstract class SortStrategy
    {
        public abstract void Sort(double[] array);
        protected void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
}
