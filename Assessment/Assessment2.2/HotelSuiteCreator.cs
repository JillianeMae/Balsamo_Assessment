using System;

namespace Assessment2._2
{
   
    public class MasterSuiteFactory : HotelSuiteFactory
    {
        protected override HotelSuite MakeReservation()
        {
            HotelSuite suite = new MasterSuite();
            return suite;
        }
    }
    public class MiniSuiteFactory : HotelSuiteFactory
    {
        protected override HotelSuite MakeReservation()
        {
            HotelSuite suite = new MiniSuite();
            return suite;
        }
    }
}

