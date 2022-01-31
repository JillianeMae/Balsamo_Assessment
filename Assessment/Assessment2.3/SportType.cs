using System;

namespace Assessment2._3
{
    public abstract class SportType
    {
        public abstract Sport GetSport(string SportType);
        public static SportType CreateSportType(string SportType)
        {
            if (SportType.Equals("Individual"))
                return new Individual();
            else
                return new Team();
        }
    }
}
