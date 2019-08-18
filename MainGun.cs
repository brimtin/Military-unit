using System;

namespace MilitaryUnit
{
    class MainGun : Weapons
    {
        public MainGun(string weaponName,
                       string weaponSound,
                       int weaponRounds,
                       int weaponMagCapacity,
                       int weaponRange) 
            : base(weaponName,
                   weaponSound,
                   weaponRounds,
                   weaponMagCapacity,
                   weaponRange)
        {

        }

        public override void Shoot(int target)
        {
            var i = 0;

            while (i < target)
            {
                Console.WriteLine("CLEAR!!!!!");
                Console.WriteLine($"{weaponSound}!!!!!!!");
                Reload();

                i++;
            }
        }
    }



}
