using Design_Patterns_Assignment.Observer.ObserverFiles;
using Design_Patterns_Assignment.Observer.SubjectFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class ObserverRun
    {
        EmailWatcher emailWatcher = new EmailWatcher();
        Email email = new Email();
        internal void Run()
        {
            email.RegisterObserver(emailWatcher);
            email.UpdateInbox(500, "First mail");
            email.UpdateInbox(1000, "Second mail");
            email.UpdateInbox(5500, "Third mail");
            email.UpdateInbox(6000, "Forth mail");
            email.UpdateInbox(80000, "Forth mail");
        }
    }
}
