using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1.Converter
{
    public class GenderToBooleanConverter : IValueConverter
    {
        // parameter is "Male" or "Female"
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string gender = value as string;
            if (gender == "Male")
            {
                return true;
            }
            else if (gender == "Female")
            {
                return true;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isChecked = (bool)value;
            if (isChecked)
                return parameter as string;
            return Binding.DoNothing; // don’t update if not checked
        }
    }

    public class AndBooleanConverter : IMultiValueConverter
    {
        // parameter is "Male" or "Female"
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.All(v => v is bool b && b);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
