using StoneFinch.ReactiveExtensions.Sut;
using System.Reactive.Concurrency;

namespace StoneFinch.ReactiveExtensions.Tests
{
    class TestSchedulerProvider : ISchedulerProvider
    {

        public IScheduler CurrentThread
        {
            get { return Scheduler.Immediate; }
        }

        public IScheduler Dispatcher
        {
            get { return Scheduler.Immediate; }
        }

        public IScheduler Immediate
        {
            get { return Scheduler.Immediate; }
        }

        public IScheduler NewThread
        {
            get { return Scheduler.Immediate; }
        }

        public IScheduler ThreadPool
        {
            get { return Scheduler.Immediate; }
        }
    }
}