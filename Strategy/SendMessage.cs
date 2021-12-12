﻿using Design_Patterns_Assignment.Strategy.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    public class SendMessage : ISendMessage
    {
        public IMessage Message { get; set; }

        public void Send(string message)
        {
            Message.Send(message);
        }
    }
}
