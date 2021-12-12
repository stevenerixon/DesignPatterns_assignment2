using Design_Patterns_Assignment;

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var decoratorRun = new DecoratorRun();
            var strategyRun = new StrategyRun();
            var repositoryRun = new RepositoryRun();
            var observerRun = new ObserverRun();

            //decoratorRun.Run();
            //repositoryRun.Run();
            //strategyRun.Run();
            observerRun.Run();
        }     
    }
}
