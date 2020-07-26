using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Cache;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using UI.Model;

namespace UI.Commons
{
    public class MessagePicConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            if((bool)value)
            {
                return @"Image\messageon.png";
            }
            else
            {
                return @"Image\messageoff.png";
            }
            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class MessagePicConvert_Add : IMultiValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{

        //    if ((bool)value)
        //    {
        //        return @"Image\addon.png";
        //    }
        //    else
        //    {
        //        return @"Image\messageoff.png";
        //    }
        //    //throw new NotImplementedException();
        //}

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values.Length == 2)
            {
                if ((bool)values[0])
                {
                    return new BitmapImage(new Uri(string.Format("/Image/{0}on.png",values[1]), UriKind.Relative));
                }
                else
                {
                    return new BitmapImage(new Uri(string.Format("/Image/{0}off.png", values[1]), UriKind.Relative));
                }
            }
            throw new NotImplementedException();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class MedicineTypeConver : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((MedicalType)value)
            {
                case MedicalType.medicine:
                    return "中药治疗";
                case MedicalType.MedicalNeedle:
                    return "针灸治疗";
                case MedicalType.medicineandnedle:
                    return "中药&针灸治疗";
                case MedicalType.inquiry:
                    return "只问诊";
                default:
                    return "错误信息";
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class StringToImageSourceConverter : IValueConverter
    {
        #region Converter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string path = (string)value;
            if (!string.IsNullOrEmpty(path))
            {
                return new BitmapImage(new Uri(path, UriKind.Absolute));
            }
            else
            {
                return null;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
        #endregion

    }



}
