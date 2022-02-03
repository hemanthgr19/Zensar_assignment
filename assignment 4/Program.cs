using System;

namespace Assignment4
{
    class Cricket
    {
        int sum = 0, avg;

        public void pointsCalculation(int no_of_matches)
        {
            int[] Score = new int[20];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter Match{0} score :", i + 1);
                Score[i] = Convert.ToInt32(Console.ReadLine());
                sum += Score[i];
            }
            avg = sum / no_of_matches;
            Console.WriteLine($"The No_of matches in IPL is: {no_of_matches}");
            Console.WriteLine($"The Total score of the matches: {sum}");
            Console.WriteLine($"The Average of Score of The Matches: {avg}");



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Cricket c = new Cricket();
            Console.WriteLine("Enter no of matches:");
            int x = Convert.ToInt32(Console.ReadLine());
            c.pointsCalculation(x);
            Console.Read();
        }
    }
}
