using StoneFinch.ReactiveExtensions.Wpf4.MyWcfServiceReference;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StoneFinch.ReactiveExtensions.Wpf4
{
    /// <summary>
    /// Interaction logic for NameSearch.xaml
    /// </summary>
    public partial class NameSearch : Window
    {
        private NameSearchViewModel ViewModel { get; set; }

        public NameSearch()
        {
            InitializeComponent();
            
            this.ViewModel = new NameSearchViewModel();
            this.DataContext = this.ViewModel;

            var service = new MyWcfServiceClient();

            var nameSearchObs = Observable.FromAsyncPattern<string, IEnumerable<string>>(service.BeginSelectNamesStartWith, service.EndSelectNamesStartWith);

            var nameTextBoxTextChanged = Observable.FromEventPattern<TextChangedEventArgs>(this.NameTextBox, "TextChanged");
            
            var textChangedObs =
                nameTextBoxTextChanged
                .ObserveOnDispatcher()
                .Select(x => ((TextBox)x.Sender).Text)
                .Throttle(TimeSpan.FromSeconds(3))
                .Where(x => x.Length >= 3)
                .Distinct();

            textChangedObs.ObserveOnDispatcher().Subscribe(x => this.ViewModel.PreviousSearches.Add(x));

            var searchResultObs =
                textChangedObs
                .Select(x => nameSearchObs(x))
                .Switch();

            searchResultObs.ObserveOnDispatcher().Subscribe(
                x => this.ViewModel.CurrentResults.ReplaceAll(x));

        }
    }
}
