﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    public class Marked : TextDecorator
    {
        public Marked(IText text) : base(text)
        {
            TextStyleStart = "<mark>";
            TextStyleFinish = "</mark>";
        }
    }
}
