﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command3Demo.Receiver;

namespace Command3Demo.ConcreteCommandClasses
{
    public class DivideCommand:Command.Command
    {
        private readonly SimpleCalculator _calculator;

        public DivideCommand(SimpleCalculator receiver) : base(receiver)
        {
            _calculator = receiver;
        }

        public override int Execute()
        {
            return _calculator.Divide();
        }
    }
}
