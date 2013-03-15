using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StoneFinch.ReactiveExtensions.Wpf4
{
    public static class ViewModelExtensions
    {
        public static void OnPropertyChanged(this INotifyPropertyChanged obj, PropertyChangedEventHandler propertyChanged, string propertyName)
        {
            var eh = propertyChanged;

            if (eh != null)
            {
                eh(obj, new PropertyChangedEventArgs(propertyName));
            }
        }

        public static void ReplaceAll<T>(this ObservableCollection<T> collection, IEnumerable<T> newCollection)
        {
            if (collection == null)
                return;

            collection.Clear();

            collection.AddEach(newCollection);
        }

        public static void AddEach<T>(this ObservableCollection<T> collection, IEnumerable<T> newCollection)
        {
            if (collection == null || newCollection == null)
                return;

            foreach (var item in newCollection)
            {
                collection.Add(item);
            }
        }
    }
}
