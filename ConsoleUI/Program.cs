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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.  - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - DONE
             * 
             * Set the properties with object initializer syntax - DONE
             */

            Vehicle car1 = new Car()
            {
                HasTrunk = true,
                Year = "1994",
                Make = "Honda",
                Model = "Civic"
                
            };
            Vehicle motorcycle1 = new Motorcycle()
            {
                HasSideCart = false,
                Year = "2002",
                Make = "Harley Davidson",
                Model = "Street Bob"
            };
            Vehicle vehicle1 = new Car() 
            {
                HasTrunk = true , 
                Make = "Kia" , 
                Model = "Soul" , 
                Year = "2012"
            };

            Vehicle vehicle2 = new Motorcycle() 
            {
                HasSideCart = false , 
                Make = "Honda", 
                Model = "Shadow" , 
                Year = "2019"
            };


            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"Year: {vehicle.Year} , Make: {vehicle.Make} , Model: {vehicle.Model}");

                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle - DONE


            #endregion            
            Console.ReadLine();
        }
    }
}
