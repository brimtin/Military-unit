using System;

namespace MilitaryUnit
{
    abstract class Personel
    {
        protected int    size;
        protected string name;
        protected string leader;

        public Personel(int size, string name, string leader)
        {
            this.size = size;
            this.name = name;
            this.leader = leader;
        }

        public virtual void Accountability()
        {
            Console.WriteLine($"{leader}, {size} Assigned, {size} Present");
        }

        public abstract void Structure();
        
    }
}
