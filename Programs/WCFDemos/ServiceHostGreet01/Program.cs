using ConceptArchitect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHostGreet01
{
    class Program
    {
        static void Main(string[] args)
        {
            //host my service on WCF
          

            var host = new ServiceHost(typeof(SimpleGreetService),
                                         new Uri("http://localhost:8000"), //base address to be used for http
                                         new Uri("net.tcp://localhost:5000")  //and net.tcp
                                         );

            //configure the end points
            host.AddServiceEndpoint(
                                typeof(IBasicGreetService),      //contract
                                new NetTcpBinding(),         //binding
                                "basic-greet"  //address
                               );

            host.AddServiceEndpoint(
                    typeof(IBasicGreetService),
                    new BasicHttpBinding(),
                    "basic-greet"             //must use http url and a unique port
                    );


            host.AddServiceEndpoint(
                                typeof(IGreetService),      //contract
                                new NetTcpBinding(),         //binding
                                "greet"  //address
                               );

            host.AddServiceEndpoint(
                    typeof(IGreetService),
                    new BasicHttpBinding(),
                    "greet"             //must use http url and a unique port
                    );


            host.AddServiceEndpoint(
                                typeof(ITimedGreetService),      //contract
                                new NetTcpBinding(),         //binding
                                "timed-greet"  //address
                               );

            host.AddServiceEndpoint(
                    typeof(ITimedGreetService),
                    new BasicHttpBinding(),
                    "timed-greet"             //must use http url and a unique port
                    );






            Console.WriteLine("starting the service...");
            host.Open();

            Console.WriteLine("service started on end points...");


            var endpoints = host.Description.Endpoints;
            
            foreach(var endpoint in endpoints)
            {
                Console.WriteLine("Name{0}\n\tBinding:{1}\n\tContract:{2}\n\tAddress:{3}", endpoint.Name,
                                                        endpoint.Binding.Name,
                                                        endpoint.Contract.ContractType.Name,
                                                        endpoint.Address
                    );

                Console.WriteLine();
            }



            Console.WriteLine("Hit enter to exit the service...");
            Console.ReadLine();
            host.Close();
            Console.WriteLine("Service is Shutdown");

        }
    }
}
