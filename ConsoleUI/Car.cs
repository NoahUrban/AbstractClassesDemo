using System;

class Car : Vehicle
{
	public Car()
	{
	}

    public bool has4Wheels { get; set; } = true;
	public bool hasTrunk { get; set; } = true;

    public override void DriveAbstract(Vehicle vehicle)
    {
        
    }
}

/* 
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
*/