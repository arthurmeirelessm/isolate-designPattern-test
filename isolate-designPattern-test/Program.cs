using isolate_designPattern_test.Factories;
using isolate_designPattern_test.Factories.Interfaces;
using isolate_designPattern_test.Models;
using isolate_designPattern_test.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isolate_designPattern_test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Transport transport = null;

            if (args.Length > 0 && args[0] == "--car")
            {
                transport = new CarTransport();
            }
            else if (args.Length > 0 && args[0] == "--motocycle")
            {
                transport = new MotocycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço: ");
            }

            if (transport != null)
            {
                transport.StartTransport();
            }
            
            Console.ReadLine(); 

        }
    }
}
