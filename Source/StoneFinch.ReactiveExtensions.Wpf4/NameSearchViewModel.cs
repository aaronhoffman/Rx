using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StoneFinch.ReactiveExtensions.Wpf4
{
    public class NameSearchViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public NameSearchViewModel()
        {
            this.PreviousSearches = new ObservableCollection<string>();
            this.CurrentResults = new ObservableCollection<string>();
        }

        public string NameSearch
        {
            get { return this._NameSearch; }
            set
            {
                if (this._NameSearch != value)
                {
                    this._NameSearch = value;
                    this.OnPropertyChanged(this.PropertyChanged, NameSearchPropertyName);
                }
            }
        }
        private string _NameSearch;
        public const string NameSearchPropertyName = "NameSearch";

        public ObservableCollection<string> PreviousSearches
        {
            get { return this._PreviousSearches; }
            set
            {
                if (this._PreviousSearches != value)
                {
                    this._PreviousSearches = value;
                    this.OnPropertyChanged(this.PropertyChanged, PreviousSearchesPropertyName);
                }
            }
        }
        private ObservableCollection<string> _PreviousSearches;
        public const string PreviousSearchesPropertyName = "PreviousSearches";

        public ObservableCollection<string> CurrentResults
        {
            get { return this._CurrentResults; }
            set
            {
                if (this._CurrentResults != value)
                {
                    this._CurrentResults = value;
                    this.OnPropertyChanged(this.PropertyChanged, CurrentResultsPropertyName);
                }
            }
        }
        private ObservableCollection<string> _CurrentResults;
        public const string CurrentResultsPropertyName = "CurrentResults";
    }
}