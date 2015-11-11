using System.ComponentModel;

namespace PhotoSwipe.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        internal void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}