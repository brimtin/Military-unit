using System;

namespace MilitaryUnit
{
    class AirPlane : Vehicles
    {
        public AirPlane(string vehicleName,
                        string vehicleType,
                        string vehicleSound,
                        int    vehicleCapacity,
                        int    vehicleFuelLevel,
                        int    vehicleTankCapacity) 
            : base(vehicleName,
                   vehicleType,
                   vehicleSound,
                   vehicleCapacity,
                   vehicleFuelLevel,
                   vehicleTankCapacity)
        {
        }

        public override void Move(int distance)
        {
            if (vehicleTankCapacity < distance)
            {
                Console.WriteLine("This destination is out of range for this aircraft");
            }
            else
            {
                base.Move(distance);
            }
        }
    }

}

