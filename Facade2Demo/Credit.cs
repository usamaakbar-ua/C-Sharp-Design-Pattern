﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Facade2Demo
{
    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>

    public class Credit
    {
        public bool HasGoodCredit(Customer c,decimal amount)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return amount > 2500;
        }
    }
}
