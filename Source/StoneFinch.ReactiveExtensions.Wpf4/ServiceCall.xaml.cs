using StoneFinch.ReactiveExtensions.Wpf4.MyWcfServiceReference;
using System;
using System.Reactive.Linq;
using System.Windows;

namespace StoneFinch.ReactiveExtensions.Wpf4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ServiceCall : Window
    {
        private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";

        public ServiceCall()
        {
            InitializeComponent();
        }

        // block
        private void GetServerTimeButton_Click(object sender, RoutedEventArgs e)
        {
            // update request time textblock
            this.RequestTimeTextBlock.Text = DateTime.UtcNow.ToString(DateTimeFormat);

            // service call may error
            try
            {
                var service = new MyWcfServiceClient();

                // service call will block
                var currentDateTimeUtc = service.GetCurrentDateTimeUtc();

                // service call returned, update textblock
                this.ServerTimeTextBlock.Text = currentDateTimeUtc.ToString(DateTimeFormat);

                // update textblock that shows we have received the response
                this.ResponseTimeTextBlock.Text = DateTime.UtcNow.ToString(DateTimeFormat);
            }
            catch
            {
                this.ServerTimeTextBlock.Text = "Error Occurred";
            }
        }


        // async/completed
        private void GetServerTimeButton2_Click(object sender, RoutedEventArgs e)
        {
            // update request time textblock
            this.RequestTimeTextBlock2.Text = DateTime.UtcNow.ToString(DateTimeFormat);

            var service = new MyWcfServiceClient();

            // wire up completed event
            service.GetCurrentDateTimeUtcCompleted += service_GetCurrentDateTimeUtcCompleted;

            // service call will not block
            service.GetCurrentDateTimeUtcAsync();
        }

        private void service_GetCurrentDateTimeUtcCompleted(object sender, GetCurrentDateTimeUtcCompletedEventArgs e)
        {
            // check for error
            if (e.Error != null)
            {
                this.ServerTimeTextBlock2.Text = "Error Occurred";
                return;
            }

            // pull the result from the args
            var currentDateTimeUtc = e.Result;

            // service call returned, update textblock
            this.ServerTimeTextBlock2.Text = currentDateTimeUtc.ToString(DateTimeFormat);

            // update textblock that shows we have received the response
            this.ResponseTimeTextBlock2.Text = DateTime.UtcNow.ToString(DateTimeFormat);
        }


        // begin/end
        private void GetServerTimeButton3_Click(object sender, RoutedEventArgs e)
        {
            // update request time textblock
            this.RequestTimeTextBlock3.Text = DateTime.UtcNow.ToString(DateTimeFormat);

            var service = new MyWcfServiceClient();

            var asyncResult = service.BeginGetCurrentDateTimeUtc(this.GetCurrentDateTimeUtcAsyncCallback, service);
        }

        public void GetCurrentDateTimeUtcAsyncCallback(IAsyncResult asyncResult)
        {
            // get reference to service from AsyncResult
            var service = asyncResult.AsyncState as MyWcfServiceClient;

            // get response from service call
            var currentDateTimeUtc = service.EndGetCurrentDateTimeUtc(asyncResult);

            this.Dispatcher.BeginInvoke((Action)(() =>
            {
                // service call returned, update textblock
                this.ServerTimeTextBlock3.Text = currentDateTimeUtc.ToString(DateTimeFormat);

                // update textblock that shows we have received the response
                this.ResponseTimeTextBlock3.Text = DateTime.UtcNow.ToString(DateTimeFormat);
            }),
            null);
        }


        // Rx
        private void GetServerTimeButton4_Click(object sender, RoutedEventArgs e)
        {
            // update request time textblock
            this.RequestTimeTextBlock4.Text = DateTime.UtcNow.ToString(DateTimeFormat);

            var service = new MyWcfServiceClient();

            var obs = Observable.FromAsyncPattern<DateTime>(service.BeginGetCurrentDateTimeUtc, service.EndGetCurrentDateTimeUtc);

            // does not block  (note: needs ObserveOnDispatcher)
            obs().Subscribe(
            
            // OnNext
            x =>
            {
                // service call returned, update textblock
                this.ServerTimeTextBlock4.Text = x.ToString(DateTimeFormat);
            },
            
            // Completed
            () =>
            {
                // the service call returned, the Observable Completed, update the response textblock
                this.ResponseTimeTextBlock4.Text = DateTime.UtcNow.ToString(DateTimeFormat);
            });
        }
    }
}