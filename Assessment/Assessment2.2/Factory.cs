using System;

namespace Assessment2._2
{
    class Factory
    {
        static void Main(string[] args)
        {

            HotelSuite hotelSuite = new MasterSuiteFactory().CreateReservation();
            if (hotelSuite != null)
            {
                Console.WriteLine("Hotel Suite Type : " + hotelSuite.GetHotelSuiteType());
                Console.WriteLine("Hotel Suite Price : " + hotelSuite.GetSuitePrice());
            }
            else
            {
                Console.Write("Invalid Hotel Suite Type");
            }
            Console.WriteLine("\n");

            hotelSuite = new MiniSuiteFactory().CreateReservation();
            if (hotelSuite != null)
            {
                Console.WriteLine("Hotel Suite Type  : " + hotelSuite.GetHotelSuiteType());
                Console.WriteLine("Hotel Suite Price  : " + hotelSuite.GetSuitePrice());
            }
            else
            {
                Console.Write("Invalid Hotel Suite Type");
            }
            Console.ReadLine();
        }
    }
}
  
