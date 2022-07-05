using isolate_designPattern_test.Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isolate_designPattern_test.Vehicles
{
    internal class Motocycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a ecomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega de moto");
        }
    }
}
