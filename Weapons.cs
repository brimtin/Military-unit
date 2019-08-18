using System;

namespace MilitaryUnit
{
    class Weapons
    {
        protected string weaponName;
        protected string weaponSound;
        protected int    weaponRounds;
        protected int    weaponMagCapacity;
        protected int    weaponRange;


        public Weapons(string weaponName, string weaponSound, int weaponRounds, int weaponMagCapacity, int weaponRange)
        {
            this.weaponName         = weaponName;
            this.weaponSound        = weaponSound;
            this.weaponRounds       = weaponRounds;
            this.weaponMagCapacity  = weaponMagCapacity;
            this.weaponRange        = weaponRange;
        }

       
        public virtual void Shoot(int target)
        {
            for (int i = 0; i < target; i++)
            {
                if (weaponRounds > 0)
                {
                    Console.WriteLine($"{weaponSound}!!!!");
                    weaponRounds--;
                }
                else
                {
                    Console.WriteLine("YOU ARE OUT OF ROUNDS. TAKE COVER NOW and RELOAD!!!!!");
                    i = target;
                }
            }
        }

        public virtual void Reload()
        {
            weaponRounds = weaponMagCapacity;
        }

    }



}
