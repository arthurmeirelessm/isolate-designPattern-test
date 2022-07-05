using isolate_designPattern_test.Factories.Interfaces;
using isolate_designPattern_test.Vehicles;
using isolate_designPattern_test.Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isolate_designPattern_test.Factories
{
     class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
