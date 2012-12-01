using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CCWpf
{
    public class UnifiedViewModelBase : INotifyPropertyChanged
    {
        private readonly Dictionary<string, PropertyChangedEventArgs> eventArgsCache;

        protected UnifiedViewModelBase()
        {
            eventArgsCache = new Dictionary<string, PropertyChangedEventArgs>();
        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventArgs args;
            if (!eventArgsCache.TryGetValue(propertyName, out args))
            {
                args = new PropertyChangedEventArgs(propertyName);
                eventArgsCache.Add(propertyName, args);
            }

            OnPropertyChanged(args);
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, args);
        }

        #endregion
    }
}
