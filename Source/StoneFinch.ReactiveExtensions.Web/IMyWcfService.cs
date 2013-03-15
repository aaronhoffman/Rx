using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StoneFinch.ReactiveExtensions.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyWcfService" in both code and config file together.
    [ServiceContract]
    public interface IMyWcfService
    {
        [OperationContract]
        DateTime GetCurrentDateTimeUtc();

        [OperationContract]
        string DateTimeToString(DateTime dateTime);

        [OperationContract]
        double GetRandomNumber();

        [OperationContract]
        IEnumerable<string> SelectNamesStartWith(string nameStartsWith);
    }
}