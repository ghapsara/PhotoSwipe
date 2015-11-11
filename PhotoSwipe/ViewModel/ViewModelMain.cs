using PhotoSwipe.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace PhotoSwipe.ViewModel
{
    class ViewModelMain : ViewModelBase
    {
        public ObservableCollection<Photo> Photos { get; set; }

        Photo _SelectedImage;

        public Photo SelectedImage
        {
            get
            {
                return _SelectedImage;
            }
            set
            {
                if(_SelectedImage != value)
                {
                    foreach(var item in Photos.Where(x => x.Selected))
                    {
                        item.Selected = false;
                    }
                    if (value != null)
                        value.Selected = true;
                    _SelectedImage = value;
                    RaisePropertyChanged("SelectedImage");
                }
            }
        }

        public ViewModelMain()
        {
            Photos = new ObservableCollection<Photo>
            {
                new Photo { Image = new BitmapImage(new Uri("ms-appx:///ImageAssets/1.jpg", UriKind.RelativeOrAbsolute)) },
                new Photo { Image = new BitmapImage(new Uri("ms-appx:///ImageAssets/2.jpg", UriKind.RelativeOrAbsolute)) },
                new Photo { Image = new BitmapImage(new Uri("ms-appx:///ImageAssets/3.jpg", UriKind.RelativeOrAbsolute)) },
                new Photo { Image = new BitmapImage(new Uri("ms-appx:///ImageAssets/4.jpg", UriKind.RelativeOrAbsolute)) },
                new Photo { Image = new BitmapImage(new Uri("ms-appx:///ImageAssets/5.jpg", UriKind.RelativeOrAbsolute)) },
                new Photo { Image = new BitmapImage(new Uri("ms-appx:///ImageAssets/6.jpg", UriKind.RelativeOrAbsolute)) },
                new Photo { Image = new BitmapImage(new Uri("ms-appx:///ImageAssets/7.jpg", UriKind.RelativeOrAbsolute)) },
            };
            this.SelectedImage = this.Photos.FirstOrDefault();
        }
    }
}
