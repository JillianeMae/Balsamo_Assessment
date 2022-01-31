using System;

namespace Assessment2._2
{
    public abstract class HotelSuiteFactory
    {
        protected abstract HotelSuite MakeReservation();
        public HotelSuite CreateReservation()
        {
            return this.MakeReservation();
        }
    }
}

