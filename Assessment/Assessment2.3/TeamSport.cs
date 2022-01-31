using System;

namespace Assessment2._3
{
    public class Team : SportType
    {
        public override Sport GetSport(string SportType)
        {
            if (SportType.Equals("Basketball"))
            {
                return new Basketball();
            }
            else
                return null;
        }
    }
}
