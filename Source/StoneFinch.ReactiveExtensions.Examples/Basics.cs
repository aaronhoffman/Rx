using System;
using System.Reactive;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Diagnostics;
using System.Collections;

namespace StoneFinch.ReactiveExtensions.Examples
{
    public class Basics
    {
        public int Total { get; set; }

        public void Example01()
        {
            var subject = new Subject<string>();

            subject.Subscribe(x =>
            {
                Debug.WriteLine(x);
            });

            subject.OnNext("Hello World");
        }

        public void Example02()
        {
                
        }

        public void Example03()
        {

        }

        public void Example04()
        {

        }

        public void Example05()
        {

        }

        public void Example06()
        {

        }

    }
}
