﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace VirtualizationTest
{
    public sealed class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (parameter == null)
            {
                if (value is bool && (bool)value) return Visibility.Visible;
                else return Visibility.Collapsed;
            }
            else
            {
                if (value is bool && (bool)value) return Visibility.Collapsed;
                else return Visibility.Visible;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
