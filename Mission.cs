namespace MilitaryUnit
{
    class Mission
    {
        protected string missionType;
        protected int    missionDistance;
        protected int    missionSize;

        public Mission(string missionType, int missionDistance, int missionSize)
        {
            this.missionType     = missionType;
            this.missionDistance = missionDistance;
            this.missionSize     = missionSize;
        }

    }
}
