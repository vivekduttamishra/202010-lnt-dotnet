using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace ConceptArchitect.Wpf
{
    public class BoolToVisibilityConverter :MarkupExtension, IValueConverter
    {

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this; //return this object iself
        }

        public Visibility DefaultInvisibleMode { get; set; } = Visibility.Hidden;
        public bool Invert { get; set; } = false;


        public object Convert(object sourceValue, Type targetType, object parameter, CultureInfo culture)
        {
            if (sourceValue == null)
                sourceValue = false; //assume null to be false

            if (!(sourceValue is bool || sourceValue is bool?))
                return sourceValue;  //I will do nothing if source is not boolean

            bool isTrue = (bool)sourceValue;

            if (Invert)
                isTrue = !isTrue;

            if (isTrue)
                return Visibility.Visible;
            else
                return DefaultInvisibleMode;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //we will not need this one.
            throw new NotImplementedException();
        }

       
    }
}
