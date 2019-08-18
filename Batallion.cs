using System;

namespace MilitaryUnit
{
    class Batallion : Brigade
    {
        public Batallion(int size, string name, string leader) 
            : base(size, name, leader)
        {
        }

        public override void Structure()
        {
            Console.WriteLine("A Battalions is usually composed of 300 to 800 soldiers and is divided into a number of Companies");
        }
    }
}
