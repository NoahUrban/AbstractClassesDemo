using System;

abstract class Vehicle
{
    public string Year { get; set; } = "2000";
    public string Make { get; set; } = "Honda";
    public string Model { get; set; } = "Civic";

    public abstract void DriveAbstract(Vehicle vehicle);

    public virtual void DriveVirtual(Vehicle vehicle)
    {
        Console.WriteLine($"I drive a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
    }
}


/*
* Create an abstract class called Vehicle
* The vehicle class shall have three string properties: Year, Make, and Model
* Set the defaults of the properties to something generic in the Vehicle class
* Vehicle class shall have an abstract method called DriveAbstract with no implementation.
* Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
*/

