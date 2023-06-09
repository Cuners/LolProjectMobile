using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace LolProjectMobile2
{
    public class ByteArrayToBitmapImageConverter : IValueConverter
	{
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is byte[] imageBytes)
            {
                ImageSource imageSource = ImageSource.FromStream(() => new MemoryStream(imageBytes));
                return imageSource;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

       /* public BitmapImage ConvertByteArrayToBitMapImage(byte[] imageByteArray)
        {
            BitmapImage img = new BitmapImage();
            using (MemoryStream memStream = new MemoryStream(imageByteArray))
            {
                img.BeginInit();
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.StreamSource = memStream;
                img.EndInit();
                img.Freeze();
            }
            return img;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage img = new BitmapImage();
            if (value != null)
            {
                img = this.ConvertByteArrayToBitMapImage(value as byte[]);
            }
            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        } */

    }
}
