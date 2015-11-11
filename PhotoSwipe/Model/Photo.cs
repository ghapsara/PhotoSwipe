using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace PhotoSwipe.Model
{
    public class Photo : INotifyPropertyChanged
    {

        BitmapImage _Image;
        bool _Selected;

        public BitmapImage Image
        {
            get
            {
                return _Image;
            }
            set
            {
                if(_Image != value)
                {
                    _Image = value;
                    RaisePropertyChanged("Image");
                }
            }
        }

        public bool Selected
        {
            get
            {
                return _Selected;
            }
            set
            {
                if(_Selected != value)
                {
                    _Selected = value;
                    RaisePropertyChanged("Selected");
                }
            }
        }


        protected void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
