using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class TextDecorator : IText
    {
        public IText Text { get; set; }
        public string Description { get; set; }

        public string TextStyleStart;
        public string TextStyleFinish;
        public TextDecorator(IText text)
        {
            Text = text;
        }
        public string GetDescription()
        {
            return TextStyleStart + Text.GetDescription() + TextStyleFinish;
        }        
    }
}
