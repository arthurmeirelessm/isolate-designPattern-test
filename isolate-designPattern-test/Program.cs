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
            Car getC = new Car();

            getC.StartRoute();

        }
    }
}
