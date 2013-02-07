using StoneFinch.ReactiveExtensions.Wpf.MyWcfServiceReference;
using System;
using System.Windows;

namespace StoneFinch.ReactiveExtensions.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetServerTimeButton_Click(object sender, RoutedEventArgs e)
        {
            // attempt to update request time textblock
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
                this.ServerTimeTextBlock2.Text = "Error Occurred";
            }
        }

        private async void GetServerTimeButton2_Click(object sender, RoutedEventArgs e)
        {
            // attempt to update request time textblock
            this.RequestTimeTextBlock2.Text = DateTime.UtcNow.ToString(DateTimeFormat);

            // service call may error
            try
            {
                var service = new MyWcfServiceClient();

                // service call will not block, but await will resume after async call
                var currentDateTimeUtc = await service.GetCurrentDateTimeUtcAsync();

                // service call returned, update textblock
                this.ServerTimeTextBlock2.Text = currentDateTimeUtc.ToString(DateTimeFormat);

                // update textblock that shows we have received the response
                this.ResponseTimeTextBlock2.Text = DateTime.UtcNow.ToString(DateTimeFormat);
            }
            catch
            {
                this.ServerTimeTextBlock2.Text = "Error Occurred";
            }
        }
    }
}