using System;

namespace MilitaryUnit
{
    class Platoon : Company
    {
        public Platoon(int size, string name, string leader) 
            : base(size, name, leader)
        {
        }

        public override void Structure()
        {
            Console.WriteLine("A Platoon is typically composed of two or more squads/sections/patrols,"+
                              " a full-strength U.S. infantry rifle platoon consists of 39 Soldiers or 43 Marines");
        }
    }
}
