using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {

            //Base Address for StudentService
            Uri httpBaseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/WCFTest/WorkerService/");

            //Instantiate ServiceHost
            var serviceHost = new ServiceHost(typeof(WCFTest.WorkerService),
                httpBaseAddress);

            //Add Endpoint to Host
            //serviceHost.AddServiceEndpoint(typeof(WCFTest.IWorkerService),
            //                                        new WSHttpBinding(), "");

            //Metadata Exchange
            //ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
            //serviceBehavior.HttpGetEnabled = true;
            //studentServiceHost.Description.Behaviors.Add(serviceBehavior);

            //Open
            serviceHost.Open();
            Console.WriteLine("Service is live now at : {0}", httpBaseAddress);
            Console.ReadKey();
        }
    }
}
