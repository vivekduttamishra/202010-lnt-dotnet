using ConceptArchitect.ConsoleUtils;
using ConceptArchitect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGreet01
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                dynamic serviceProxy = CreateProxy();

                var name = Input.Read<string>("Your Name? ", "Vivek");
                DoWelcome(serviceProxy, name);
                DoGoodBye(serviceProxy, name);
                DoTimedGreet(serviceProxy, name);
                DoGetOut(serviceProxy, name);

            }
        }

        private static dynamic CreateProxy()
        {
            var url = Input.Read<string>("URL? ");
            //var contractChoice = Input.Read<int>("1. Basic Greet 2. Full Greet 3. Timed Greet");

            //ConceptArchitect.Services.IGreetService, ConceptArch  ConceptArchitect.Services.GreetServiceContract, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullitect.Services.GreetServiceContract, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null


            Binding binding = null;


            if (url.ToLower().StartsWith("http"))
                binding = new BasicHttpBinding();
            else
                binding = new NetTcpBinding();


            dynamic serviceProxy;

            if (url.EndsWith("basic-greet"))


                serviceProxy = ChannelFactory<IBasicGreetService>                //contract
                                                    .CreateChannel(
                                                            binding, //binding
                                                            new EndpointAddress(url) //address
                                                    );
            else if (url.EndsWith("timed-greet"))
                serviceProxy = ChannelFactory<ITimedGreetService>                //contract
                                                    .CreateChannel(
                                                            binding, //binding
                                                            new EndpointAddress(url)); //address


            else
                serviceProxy = ChannelFactory<IGreetService>                //contract
                                                    .CreateChannel(
                                                            binding, //binding
                                                            new EndpointAddress(url)); //address
            return serviceProxy;
        }

        private static void DoWelcome(dynamic serviceProxy, string name)
        {
            try
            {
                var welcomeMessage = serviceProxy.Welcome(name);
                Console.WriteLine(welcomeMessage);
            }catch(Exception ex)
            {
                Console.WriteLine("Error:"+ex.Message);
            }
        }

        private static void DoGoodBye(dynamic serviceProxy, string name)
        {
            try
            {
                var welcomeMessage = serviceProxy.GoodBye(name);
                Console.WriteLine(welcomeMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private static void DoTimedGreet(dynamic serviceProxy, string name)
        {
            try
            {
                var welcomeMessage = serviceProxy.TimedGreet(name);
                Console.WriteLine(welcomeMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private static void DoGetOut(dynamic serviceProxy, string name)
        {
            try
            {
                var welcomeMessage = serviceProxy.GetOut(name);
                Console.WriteLine(welcomeMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
