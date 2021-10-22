using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace ConceptArchitect.Wpf
{
    public class BooleanInverter : MarkupExtension,IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //converts source value to target type
            return InvertBoolean(value);
        }

        private static object InvertBoolean(object value)
        {
            if (value is bool || value is bool?)
                return !((bool)value); //send a reverse value
            else
                return value; //do not change. return the original
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //convert from target to source type (used for two way data binding)
            return InvertBoolean(value);
        }

        
    }
}
