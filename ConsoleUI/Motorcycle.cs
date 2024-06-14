using System;

class Motorcycle : Vehicle 
{
    public Motorcycle()
    {
    }

    public bool has2Wheels { get; set; } = true;
    public bool needHelmet { get; set; } = true;

    public override void DriveAbstract(Vehicle vehicle)
    {
    }

    public override void DriveVirtual(Vehicle vehicle)
    {
        Console.WriteLine($"I drive a motorcycle. It is a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
    }


}


/* 
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
*/