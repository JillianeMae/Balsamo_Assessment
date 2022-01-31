using System;

namespace Assessment2._3
{
    public class Individual : SportType
    {
        public override Sport GetSport(string SportType)
        {
            if (SportType.Equals("Boxing"))
            {
                return new Boxing();
            }
            else
                return null;
        }
    }
}
