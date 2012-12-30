using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Media.Imaging;

namespace WpfImage
{
    public class ViewModel : UnifiedViewModelBase 
    {
        private BitmapImage _image;
        public BitmapImage Image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged("Image");
            }
        }
    }
}
