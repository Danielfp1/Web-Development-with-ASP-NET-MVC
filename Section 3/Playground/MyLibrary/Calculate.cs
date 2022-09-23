﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class AddCalculate : ICalculate
    {
        public int PerformeCal(int n1, int n2)
        {
            return n1 + n2;
        }
    }
    public class SubCalculate : ICalculate
    {
        public int PerformeCal(int n1, int n2)
        {
            return n1 - n2;
        }
    }
    public class MultiplyCalculate : ICalculate
    {
        public int PerformeCal(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}