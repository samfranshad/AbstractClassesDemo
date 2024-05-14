using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            var carOne = new Car() { Year = "2016", Make = "Buick", Model = "Encore", HasTrunk = true };
            var motorcycleOne = new Motorcycle() { Year = "2020", Make = "Honda", Model = "SuperCub", HasSideCart = false };
            Vehicle carTwo = new Car() { Year = "2023", Make = "Mazda", Model = "3", HasTrunk = true };
            Vehicle motorcycleTwo = new Motorcycle() { Year = "2019", Make = "Harley Davidson", Model = "Sportster", HasSideCart = true };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.Add(carOne);
            vehicles.Add(motorcycleOne);
            vehicles.Add(carTwo);
            vehicles.Add(motorcycleTwo);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}\nMake: {vehicle.Make}\nModel: {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            carOne.DriveAbstract();
            carOne.DriveVirtual();

            motorcycleOne.DriveAbstract();
            motorcycleOne.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
