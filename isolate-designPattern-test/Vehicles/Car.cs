using isolate_designPattern_test.Models;
using isolate_designPattern_test.Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isolate_designPattern_test.Vehicles
{
    public class Car : IVehicle
    {

        public void GetCar()
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Type: ");
            string type = Console.ReadLine();


            CarModel car = new CarModel();

            car.Name = name;
            car.Description = description;
            car.Type = type;


            List<CarModel> carModels = new List<CarModel>();

            carModels.Add(car);


            foreach (CarModel items in carModels)
            {

                Console.WriteLine(items.Name);
                Console.WriteLine(items.Description);
                Console.WriteLine(items.Type);
            }


        }

        public void StartRoute()
        {
            throw new NotImplementedException();
        }
    }
}
