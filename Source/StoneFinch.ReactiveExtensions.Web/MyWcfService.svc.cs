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
        private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";

        public DateTime GetCurrentDateTimeUtc()
        {
            // simulate work....
            Thread.Sleep(2000);

            var x = 1;
            if (x == 2)
            {
                throw new Exception("Error Occurred.");
            }
            
            return DateTime.UtcNow;
        }

        public string DateTimeToString(DateTime dateTime)
        {
            // simulate work....
            Thread.Sleep(4000);

            var x = 1;
            if (x == 2)
            {
                throw new Exception("Error Occurred.");
            }

            return dateTime.ToString(DateTimeFormat);
        }

        public double GetRandomNumber()
        {
            // simulate work....
            Thread.Sleep(4000);

            var x = 1;
            if (x == 2)
            {
                throw new Exception("Error Occurred.");
            }

            return new Random().NextDouble();
        }
    }
}