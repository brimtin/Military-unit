using System;

namespace MilitaryUnit
{
    class Vehicles
    {
        protected string vehicleName;
        protected string vehicleType;
        protected string vehicleSound;
        protected int vehicleCapacity;
        protected int vehicleFuelLevel;
        protected int vehicleTankCapacity;
        protected bool vehicleStatus = true;

        public Vehicles(string vehicleName,
                        string vehicleType,
                        string vehicleSound,
                        int vehicleCapacity,
                        int vehicleFuelLevel,
                        int vehicleTankCapacity)
        {
            this.vehicleName = vehicleName;
            this.vehicleType = vehicleType;
            this.vehicleSound = vehicleSound;
            this.vehicleCapacity = vehicleCapacity;
            this.vehicleFuelLevel = vehicleFuelLevel;
            this.vehicleTankCapacity = vehicleTankCapacity;
        }

        public virtual void Move(int distance)
        {

            Console.WriteLine();

            var i = 0;
            if (vehicleStatus)
            {

                while (i < distance)
                {
                    if (vehicleFuelLevel > 0)
                    {
                        Console.Write($"{vehicleSound}!!!");

                        vehicleFuelLevel--;
                    }
                    else
                    {
                        Console.WriteLine("OH NOO! YOU ARE OUT OF FUEL!!!!");
                        i = distance;
                    }

                    i += (distance/ 10) ;
                }
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("THIS VEHICLE IS UNSERVICEABLE!!!!");
            }

             vehicleStatus = false;
        }

        public virtual void Refuel()
        {
            Console.WriteLine("Refueling........");

            vehicleFuelLevel = vehicleTankCapacity;
        }

        public virtual void Service()
        {
            Refuel();
            vehicleStatus = true;
            Console.WriteLine($"{vehicleName} is ready for the next trip!");

        }
    }

}

