namespace StoneFinch.ReactiveExtensions.Sut
{
    public class MyServiceUnderTest
    {
        public MyServiceUnderTest(ISchedulerProvider schedulerProvider)
        {
            this.SchedulerProvider = schedulerProvider;
        }

        private ISchedulerProvider SchedulerProvider { get; set; }
    }
}