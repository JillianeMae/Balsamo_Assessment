using System;

namespace Assessment2._3
{
    class AbstractFactory
    {
        static void Main(string[] args)
        {
            Sport sport = null;
            SportType sportType = null;
            string sportBenefit = null;
            
            sportType = SportType.CreateSportType("Individual");
            Console.WriteLine("Type of Sport : " + sportType.GetType().Name);
            
            sport = sportType.GetSport("Boxing");
            Console.WriteLine("Sport: " + sport.GetType().Name);
            sportBenefit = sport.benefit();
            Console.WriteLine(sport.GetType().Name + " Benefit : " + sportBenefit);
            Console.WriteLine("\n");
            
            sportType = SportType.CreateSportType("Team");
            Console.WriteLine("Type of Sport : " + sportType.GetType().Name);
            
            sport = sportType.GetSport("Basketball");
            Console.WriteLine("Sport: " + sport.GetType().Name);
            sportBenefit = sport.benefit();
            Console.WriteLine(sport.GetType().Name + " Benefit : " + sportBenefit);
            Console.ReadLine();
        }
    }
}
