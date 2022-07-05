using isolate_designPattern_test.Vehicles;
using isolate_designPattern_test.Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isolate_designPattern_test.Factories.Interfaces
{
     class MotocycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motocycle();
        }
    }
}
