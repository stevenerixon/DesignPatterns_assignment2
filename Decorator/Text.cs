using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class Text : IText
    {
        public string Description { get; set; }

        public string GetDescription()
        {
            return Description;
        }
        
    }
}
