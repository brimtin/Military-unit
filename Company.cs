using System;

namespace MilitaryUnit
{
    class Company : Batallion
    {
        public Company(int size, string name, string leader) 
            : base(size, name, leader)
        {
        }

        public override void Structure()
        {
            Console.WriteLine("A company is a military unit, typically consisting of 80–150 soldiers " +
                              "Most companies are formed of three to six platoons"); 
        }
    }
}
