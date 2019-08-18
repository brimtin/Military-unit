using System;

namespace MilitaryUnit
{
    class Brigade : Personel
    {
        public Brigade(int size, string name, string leader) 
            : base(size, name, leader)
        {

        }

        public override void Structure()
        {
            Console.WriteLine("A Brigade is usually composed of three to six " +
                                "Battalions plus supporting elements. ");
        }
    }
}
