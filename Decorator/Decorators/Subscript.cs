﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    public class Subscript : TextDecorator
    {
        public Subscript(IText text) : base(text)
        {
            TextStyleStart = "<sub>";
            TextStyleFinish = "</sub>";
        }
    }
}
