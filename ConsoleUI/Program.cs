using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicleList = new List<Vehicle>();

            Car car1 = new Car() { Year = "2012", Make = "Honda", Model = "Civic", has4Wheels = true, hasTrunk = true };

            vehicleList.Add(car1);

            Motorcycle motorcycle1 = new Motorcycle() { Year = "2024", Make = "Indian", Model = "Scout", has2Wheels = true, needHelmet = true };

            vehicleList.Add(motorcycle1);

            Vehicle car2 = new Car() { Year = "1965", Make = "Chevy", Model = "Camero", has4Wheels = true, hasTrunk = true };

            vehicleList.Add(car2);

            Vehicle motorcycle2 = new Motorcycle() { Year = "1984", Make = "Harley Davidson", Model = "Chopper", has2Wheels = true, needHelmet = true };

            vehicleList.Add(motorcycle2);

            int vehicleNumber = 0;

            foreach (Vehicle item in vehicleList)
            {
                vehicleNumber++;
                Console.WriteLine($"Vehicle {vehicleNumber}");
                Console.WriteLine($" Year: {item.Year}");
                Console.WriteLine($" Make: {item.Make}");
                Console.WriteLine($" Model: {item.Model}\n");
            }

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract(car1);
            motorcycle2.DriveAbstract(motorcycle2);

            car1.DriveVirtual(car1);
            motorcycle2.DriveVirtual(motorcycle2);

            #endregion            
            Console.ReadLine();
        }
    }
}
