﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1.Converter
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {          

            bool isvisible = (bool)value;
            if (isvisible)
            {
                return Visibility.Visible;
            }
            else
            {
               return  Visibility.Collapsed;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
         

            if ((Visibility)value==Visibility.Visible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

   

}
