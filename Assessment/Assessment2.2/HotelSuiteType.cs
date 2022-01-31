using System;

namespace Assessment2._2
{
    public class MasterSuite : HotelSuite
    {
        public string GetHotelSuiteType()
        {
            return "Master Suite";
        }
        public int GetSuitePrice()
        {
            return 15000;
        }
    }
    public class MiniSuite : HotelSuite
    {
        public string GetHotelSuiteType()
        {
            return "Mini Suite";
        }
        public int GetSuitePrice()
        {
            return 7500;
        }
    }
}
  
