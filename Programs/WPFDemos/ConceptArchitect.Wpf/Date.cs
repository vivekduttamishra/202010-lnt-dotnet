using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConceptArchitect.Wpf
{
    public class Date : MarkupExtension
    {

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return ToString();  //return this value to whoever ask.
        }



        public DateTime date;

        public string Value
        {
            get
            {
                return date.ToString();
            }
            set
            {
                date = DateTime.Parse(value);
            }
        }

        
        public string Format { get; set; }

        public Date()
        {
            date = DateTime.Now;
            Format = "dd-MMM-yyyy, HH:mm:ss";
        }
        public Date(string value)
        {
            Value = value;
        }


        public override string ToString()
        {
            return date.ToString(Format);
        }

       
    }
}
