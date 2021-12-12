using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.ObserverFiles
{
    public class EmailWatcher : IObserver
    {
        public void Update(DateTime time, string message)
        {
            Console.WriteLine($"Youg recieved and email at {time} with the following message: {message}");
        }
    }
}
