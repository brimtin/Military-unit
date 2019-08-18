using System;

namespace MilitaryUnit
{
    class Squad : Platoon
    {
        public Squad(int size, string name, string leader) : 
            base(size, name, leader)
        {
        }

        public override void Structure()
        {
            Console.WriteLine("A Squad consists of eight to fourteen soldiers," +
                " and may be further subdivided into fireteams.");
        }
    }
}
