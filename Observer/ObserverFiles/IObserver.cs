﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.ObserverFiles
{
    public interface IObserver
    {
        public void Update(DateTime time, string message);
    }
}
