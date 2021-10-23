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
            var host = new ServiceHost(typeof(SimpleGreetService));


            Console.WriteLine("starting the service...");
            host.Open();

            Console.WriteLine("service started on end points...");

            var endpoints = host.Description.Endpoints;
            
            foreach(var endpoint in endpoints)
            {
                Console.WriteLine("Name: {0}\n\tBinding:{1}\n\tContract:{2}\n\tAddress:{3}", endpoint.Name,
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
