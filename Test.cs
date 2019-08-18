using System;

namespace MilitaryUnit
{
    class Test
    {

        readonly Brigade brigade     = new Brigade(2000, "44th MED BDE", "Colonel Smith");
        readonly Batallion battalion = new Batallion(800, "28th CSH", "Lt Colonel Smurphy");
        readonly Company company     = new Company(200, "Alpha Company", "Captain Jones");
        readonly Platoon platoon     = new Platoon(30, "1st Platoon", "Staff Sergeant Cole");
        readonly Platoon squad       = new Squad(8, "1st Squad", "Sergeant Brown");


        readonly LandVehicles humvee = new LandVehicles("Humvee", "Light transport", "VROOM", 5, 100, 100);
        readonly LandVehicles tank   = new LandVehicles("Abrams", "Armored", "VROOM", 4, 200, 200);
        readonly LandVehicles lmtv   = new LandVehicles("LMTV", "Troop Carrier", "VROOM", 30, 150, 150);

        readonly AirPlane c17 = new AirPlane("C17 GlobeMaster", "Cargo Plane", "WHOOSH", 100, 5000, 5000);
        readonly AirPlane b52 = new AirPlane("B-52", "Bomber", "WHOOSH", 10, 6000, 6000);


        readonly SmallArm rifle      = new SmallArm("M-4", "PEW", 30, 30, 300);
        readonly SmallArm machineGun = new SmallArm(".50 CAL", "BRAATTTATTATA", 1000, 1000, 1800);
        readonly MainGun howitzer    = new MainGun("Howitzer", "BOOM", 1, 1, 18100);



        public void Run()
        {
            Deployment();

            FTX();

            PT();

            TroopMovement();

            LiveFireExcercise();
        }

        private void Deployment()
        {


            Console.WriteLine("We are deploying to MARS, for 9 months and we will need the whole brigade!");


            Console.WriteLine();
            brigade.Structure();

            Console.WriteLine("\nBefore we leave, we hold an accountability formattion to make sure that everyone is present");
            Console.WriteLine();
            brigade.Accountability();


            Console.ReadLine();

        }

        private void FTX()
        {
            Console.Clear();

            Console.WriteLine("We are going to the field, for 2 weeks and we taking the whole Battalion");

            Console.WriteLine();
            battalion.Structure();

            Console.WriteLine("\nBefore we leave for the field, we hold an accountability formattion to make sure that everyone is present");
            Console.WriteLine();
            battalion.Accountability();

            Console.ReadLine();


        }

        private void PT()
        {
            Console.Clear();

            Console.WriteLine("There is a company run every friday in most units");

            Console.WriteLine();
            company.Structure();

            Console.WriteLine();
            Console.WriteLine("Before we leave for the run we hold an accountability formattion to make sure that everyone is present");


            Console.WriteLine("\nThe squad leader makes sure, that all soldier assigned to squad are present");
            squad.Accountability();

            Console.WriteLine("\nThe Platoon Sergeant does the same");
            platoon.Accountability();

            Console.WriteLine("\nFinally, the first sergeant gives the report to the Commander of troops");
            company.Accountability();

            Console.ReadLine();


        }


        private void TroopMovement()
        {
            Movement(humvee, 100);

            Movement(tank, 200);

            Movement(lmtv, 150);

            Console.Clear();
            c17.Move(50000);
            c17.Move(5000);
            c17.Service();
            Console.ReadLine();

            Console.Clear();
            b52.Move(10000);
            b52.Move(6000);
            b52.Service();
            Console.ReadLine();

        }

        private void Movement(Vehicles vehicle, int distance)
        {
            Console.Clear();

            vehicle.Move(distance);
            vehicle.Move(distance);
            vehicle.Service();
            vehicle.Move(distance);
            vehicle.Service();

            Console.ReadLine();

        }

        private void LiveFireExcercise()
        {
            Console.WriteLine("Units conduct training missions from time to time to maintain combat readiness");

            Fire(rifle, 40);
            Fire(rifle, 20);

            Fire(machineGun, 2000);
            Fire(machineGun, 1000);

            Fire(howitzer, 10);

        }

        private void Fire(Weapons weapon, int target)
        { 
            Console.Clear();
            weapon.Shoot(target);
            weapon.Reload();
            Console.ReadLine();
        }



    }
}
