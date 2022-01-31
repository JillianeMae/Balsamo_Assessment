using System;

namespace Assessment2._1
{
    class Singleton
    {
        static void Main(string[] args)
        {
            NaturalNumbers naturalNumbers = NaturalNumbers.Instance;
            naturalNumbers.DisplayNaturalNumbers();
        }
    }
    public class NaturalNumbers
    {
        private static NaturalNumbers instance = new NaturalNumbers();
        private NaturalNumbers() { }

        public static NaturalNumbers Instance
        {
            get { return instance; }
        }
        public void DisplayNaturalNumbers()
        {
            int i;
            Console.WriteLine("The first 10 natural number are:");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();
        }

    }
}
