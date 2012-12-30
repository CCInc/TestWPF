using System.ComponentModel;

namespace CCProgressBar
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;
    }
}