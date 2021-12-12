using Design_Patterns_Assignment.Observer.ObserverFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer.SubjectFiles
{
    public class Email
    {
        public List<IObserver> Observers { get; set; }
        public DateTime Time { get; set; }

        public Email()
        {
            Observers = new();
        }
        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void UnRegisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void NotifyObservers(string message)
        {
            foreach(var observer in Observers)
            {
                observer.Update(Time, message);
            }
        }
        public void UpdateInbox(int seconds, string message) 
        {
            Task.Delay(seconds).Wait();
            Time = DateTime.Now;
            NotifyObservers(message);
        }
    }
}
