using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoneFinch.ReactiveExtensions.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Method");

            var p = new Program();
            p.Example07();

            Console.WriteLine("After Method");
            Console.ReadLine();
        }

        public void Example01()
        {
            // Hello World, Subscribe to OnNext

            var subject = new Subject<string>();

            subject.Subscribe(x =>
            {
                Console.WriteLine(x);
            });

            subject.OnNext("Hello World");
        }

        public void Example011()
        {
            // Observable - OnNext, OnComplete
            // (note: Determines delegate by param types)

            var subject = new Subject<int>();

            subject.Subscribe(

            // OnNext
            x =>
            {
                Console.WriteLine(x);
            },

            // OnCompleted
            () =>
            {
                Console.WriteLine("On Completed");
            });

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();
            subject.OnNext(4);
        }

        public void Example012()
        {
            // Observable - OnNext, OnError
            // (note: Determines delegate by param types)

            var subject = new Subject<int>();

            subject.Subscribe(

            // OnNext
            x =>
            {
                Console.WriteLine(x);
            },

            // OnError
            ex => 
            {
                Console.WriteLine(ex.Message);
            },

            // OnCompleted
            () =>
            {
                Console.WriteLine("On Completed");
            });

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnError(new Exception("Error Occurred"));
            //subject.OnNext(4);
            //subject.OnCompleted();
            //subject.OnNext(4);
        }

        public void Example02()
        {
            // Enumerable vs. Observable
            // (note: GoToDef for "Range" of each)

            // Enumerable
            var items = Enumerable.Range(10, 5);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            // Observable
            var obs = Observable.Range(10, 5);

            obs.Subscribe(x => Console.WriteLine(x));
        }

        public void Example03()
        {
            // Enumerable vs. Observable - Wait

            // Enumerable
            var items = Enumerable.Range(10, 5);

            foreach (var item in items)
            {
                Thread.Sleep(1000);
                Console.WriteLine(item);
            }

            Console.WriteLine("Enumerable Done");


            // Observable
            var obs = Observable.Range(10, 5);

            obs.Subscribe(x =>
            {
                Thread.Sleep(1000);
                Console.WriteLine(x);
            });

            Console.WriteLine("Subscribe Done");
        }

        public void Example04()
        {
            // Observable - Timers

            var obs = Observable.Range(10, 5);

            obs.Delay(TimeSpan.FromSeconds(2)).Subscribe(x =>
            {
                Console.WriteLine(x);
            });

            Console.WriteLine("Subscribe Done");
        }

        public void Example05()
        {
            // Observable - Interval

            var obs = Observable.Interval(TimeSpan.FromSeconds(2));

            obs.Subscribe(x =>
            {
                Console.WriteLine(x);
            });

            Console.WriteLine("Subscribe Done");
        }

        public void Example06()
        {
            // Observables - LINQ

            var obs = Observable.Interval(TimeSpan.FromSeconds(2));

            var q =
                from o in obs
                where o % 2 == 0
                select o;

            q.Subscribe(x => Console.WriteLine(x));
        }

        public void Example07()
        {
            // Observables - LINQ, Join

            var obs1 = Observable.Interval(TimeSpan.FromSeconds(1));
            var obs2 = Observable.Interval(TimeSpan.FromSeconds(2));

            var obs3 = obs1.CombineLatest(obs2, (o1, o2) => o1 + o2);

            var q =
                from o in obs3
                where o % 3 == 0
                select o;

            q.Subscribe(x => Console.WriteLine(x));
        }

        public void Example08()
        {
            // Observables - LINQ, Compose

            var obs1 = Observable.Interval(TimeSpan.FromSeconds(1));
            
            var q =
                from o in obs1
                where o % 2 == 0
                select o;

            var q2 =
                from o in q
                where o % 4 == 0
                select o;

            q2.Subscribe(x => Console.WriteLine(x));
        }
        


    }
}