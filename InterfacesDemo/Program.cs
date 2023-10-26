using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Interfaces calisma

        IWorker[] workers = new IWorker[3]
        {
            new Manager(),
            new Worker(),
            new Robot()
        };

        foreach (var w in workers)
        {
            w.Work();
        }

        IEat[] eats = new IEat[3];

        foreach (var e in eats)
        {
            e.Eat();
        }

        ISalary[] salaries = new ISalary[3];

        foreach (ISalary s in salaries)
        {
            s.GetSalary();
        }
    }

    interface IWorker
    {
        void Work();
    }

    //SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}