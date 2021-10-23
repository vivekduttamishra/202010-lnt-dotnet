using ConceptArchitect.ConsoleUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceClientGreet02.GreetServiceProxy;

namespace ServiceClientGreet02
{
    class Program
    {
        static void Main(string[] args)
        {
            var greet = new GreetServiceClient("http-greet");

            var timedGreet = new TimedGreetServiceClient("tcp-timed-greet");

            var name=Input.Read<string>("name?");

            var welcomeMessage = greet.Welcome(name);
            var goodByeMessage = greet.GoodBye(name);

            var timedGreetMessage = timedGreet.TimedGreet(name);


            Console.WriteLine(welcomeMessage);
            Console.WriteLine(goodByeMessage);
            Console.WriteLine(timedGreetMessage);
        }
    }
}
