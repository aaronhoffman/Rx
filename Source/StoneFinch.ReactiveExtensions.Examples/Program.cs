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
            Console.WriteLine("Start");

            var p = new Program();
            p.Example08();

            Console.WriteLine("End");
            Console.ReadLine();
        }

        public void Example01()
        {
            // Hello World, Subscribe to OnNext

            // compare Subscribe below to
            // subject.PropertyChanged += subject_PropertyChanged
            // or
            // subject.PropertyChanged += (s, e) => { Console.WriteLine(""); };

            var subject = new Subject<string>();

            subject.Subscribe(x =>
            {
                Console.WriteLine(x);
            });

            subject.OnNext("Hello World");


            // OUTPUT
            /*
                Start
                Hello World
                End
            */
        }

        public void Example02()
        {
            // Observable - OnNext, OnComplete
            // (note: Determines delegate by param types)

            var subject = new Subject<int>();

            subject.Subscribe(

            // OnNext
            x =>
            {
                Console.WriteLine("OnNext: {0}", x);
            },

            // OnCompleted
            () =>
            {
                Console.WriteLine("OnCompleted");
            });

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();

            // OnNext after OnCompleted is not allowed
            subject.OnNext(4);


            // OUTPUT
            /*
                Start
                OnNext: 1
                OnNext: 2
                OnNext: 3
                OnCompleted
                End
            */
        }

        public void Example03()
        {
            // Observable - OnNext, OnError
            // (note: Determines delegate by param types)

            var subject = new Subject<int>();

            subject.Subscribe(

            // OnNext
            x =>
            {
                Console.WriteLine("OnNext: {0}", x);
            },

            // OnError
            ex =>
            {
                Console.WriteLine(ex.Message);
            },

            // OnCompleted
            () =>
            {
                Console.WriteLine("OnCompleted");
            });

            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnError(new Exception("OnError"));

            // OnNext/OnCompleted after OnError not allowed
            ////subject.OnNext(4);
            ////subject.OnCompleted();


            // OUTPUT
            /*
            Start
            OnNext: 1
            OnNext: 2
            OnNext: 3
            OnError
            End
            */
        }

        public void Example04()
        {
            // Enumerable vs. Observable
            // (note: GoToDef for "Range" of Enumerable vs. Observable)

            // Enumerable
            var items = Enumerable.Range(10, 5);

            foreach (var item in items)
            {
                Console.WriteLine("MoveNext: {0}", item);
            }

            Console.WriteLine("Enumerable Done");


            // Observable
            var obs = Observable.Range(10, 5);

            obs.Subscribe(x => Console.WriteLine("OnNext: {0}", x));

            Console.WriteLine("Observable Done");


            // OUTPUT
            /*
                Start
                MoveNext: 10
                MoveNext: 11
                MoveNext: 12
                MoveNext: 13
                MoveNext: 14
                Enumerable Done
                OnNext: 10
                OnNext: 11
                OnNext: 12
                OnNext: 13
                OnNext: 14
                Observable Done
                End
            */
        }

        public void Example05()
        {
            // Interval pushes number every X seconds
            var obs = Observable.Interval(TimeSpan.FromSeconds(1));

            // Delay obs
            var delayObs = obs.Delay(TimeSpan.FromSeconds(1));

            // Buffer Obs
            var delayBufferObs = delayObs.Buffer(3);

            delayBufferObs.Subscribe(x => Console.WriteLine("OnNext: {0}", String.Join(", ", x)));

            // Also Available: .Throttle() .Min() .Max() .Switch() .Distinct()


            // OUTPUT
            /*
                Start
                End
                OnNext: 0, 1, 2
                OnNext: 3, 4, 5
                OnNext: 6, 7, 8
                OnNext: 9, 10, 11
                OnNext: 12, 13, 14
                OnNext: 15, 16, 17
            */
        }

        public void Example06()
        {
            // Observables - LINQ

            var obs = Observable.Interval(TimeSpan.FromSeconds(2));

            var q =
                from o in obs
                where o % 2 == 0
                select o;

            q.Subscribe(x => Console.WriteLine("OnNext: {0}", x));

            // Also Available: projection in the Select(). ex: select new { orig = o, my = o+1 }


            // OUTPUT
            /*
                Start
                End
                OnNext: 0
                OnNext: 2
                OnNext: 4
                OnNext: 6
                OnNext: 8
                OnNext: 10
            */
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

            q.Subscribe(x => Console.WriteLine("OnNext: {0}", x));


            // OUTPUT
            /*
                Start
                End
                OnNext: 0
                OnNext: 3
                OnNext: 6
                OnNext: 9
                OnNext: 12
                OnNext: 15
                OnNext: 18
            */
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

            q2.Subscribe(x => Console.WriteLine("OnNext: {0}", x));


            // OUTPUT
            /*
                Start
                End
                OnNext: 0
                OnNext: 4
                OnNext: 8
                OnNext: 12
                OnNext: 16
            */
        }
    }
}