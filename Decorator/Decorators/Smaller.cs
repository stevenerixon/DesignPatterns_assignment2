using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    public class Smaller : TextDecorator
    {
        public Smaller(IText text) : base(text)
        {
            TextStyleStart = "<small>";
            TextStyleFinish = "</small>";
        }
    }
}
