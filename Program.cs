﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++) {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
