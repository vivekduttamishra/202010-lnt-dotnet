using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.Services
{
    public class SimpleGreetService : IBasicGreetService, IGreetService, ITimedGreetService
    {
        public SimpleGreetService()
        {
            Console.WriteLine("Service Object Created...");
        }

        public string Welcome(string name)
        {
            Console.WriteLine("sending welcome message to "+name);
            return string.Format("Hello {0}, Welcome to Simple Greet Service", name);
        }

        public string GoodBye(string name)
        {
            Console.WriteLine("sending goodby message to " + name);
            return string.Format("Good Bye {0}, Thanks for using our service.", name);
        }

        public string GetOut(string name)
        {
            Console.WriteLine("kicking out " + name);
            return string.Format("You {0}!, Get Out and don't come back again!", name);
        }

        public string TimedGreet(string name)
        {
            var hour = DateTime.Now.Hour;
            string prefix = "";
            if (hour < 12)
                prefix = "Good Morning";
            else if (hour < 17)
                prefix = "Good Afternoon";
            else
                prefix = "Good Evening";

            return string.Format("{0} {1}, Hope you are enjoying your time",prefix,name );


        }
    }
}
