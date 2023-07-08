﻿using System;
using System.Collections.Generic;
using System.Text;
using Flyweight2Demo.Flyweight_Interface;

namespace Flyweight2Demo.ConcreteFlyweight
{

    /// <summary>
    /// ConcreteFlyweight class
    /// </summary>
    internal class Rectangle:IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }
}
