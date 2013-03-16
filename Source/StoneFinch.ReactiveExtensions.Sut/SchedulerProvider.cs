using System;
using System.Reactive.Concurrency;

namespace StoneFinch.ReactiveExtensions.Sut
{
    public class SchedulerProvider : ISchedulerProvider
    {
        public IScheduler CurrentThread
        {
            get { return Scheduler.CurrentThread; }
        }

        public IScheduler Dispatcher
        {
            get { throw new NotImplementedException(); }
        }

        public IScheduler Immediate
        {
            get { return Scheduler.Immediate; }
        }

        public IScheduler NewThread
        {
            get { return NewThreadScheduler.Default; }
        }

        public IScheduler ThreadPool
        {
            get { return ThreadPoolScheduler.Instance; }
        }
    }
}