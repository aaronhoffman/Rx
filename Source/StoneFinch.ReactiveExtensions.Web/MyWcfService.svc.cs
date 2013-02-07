using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace StoneFinch.ReactiveExtensions.Web
{
    public class MyWcfService : IMyWcfService
    {
        public DateTime GetCurrentDateTimeUtc()
        {
            // simulate work....
            Thread.Sleep(2000);

            //throw new Exception("Error Occurred");

            return DateTime.UtcNow;
        }
    }
}