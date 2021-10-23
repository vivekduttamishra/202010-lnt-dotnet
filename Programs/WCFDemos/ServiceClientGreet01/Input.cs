using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.ConsoleUtils
{
    public class Input
    {
        public static T Read<T>(string prompt = "?", T defaultValue=default(T))
        {
            Console.Write(prompt);
            try
            {
                var value = Console.ReadLine();
                return (T)Convert.ChangeType(value, typeof(T));
            } catch
            {
                return defaultValue;
            }
        }
    }
}
