namespace MilitaryUnit
{
    class LandVehicles : Vehicles
    {
        public LandVehicles(string vehicleName,
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

    }

}

